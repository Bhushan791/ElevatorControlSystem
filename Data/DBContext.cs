using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ElevatorControlSystem.Data
{
    internal class DBContext
    {
        // Local SQL Server Express, Windows Auth, secure connection
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=testdb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        // Insert logs from DataTable into DB
        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Elevator_Log (LogTime, EventDescription) VALUES (@Time, @Log)";

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "LogTime");
                        adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription");

                        conn.Open();
                        adapter.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB: " + ex.Message);
            }
        }

        // Load logs from DB into DataGridView
        public void LoadLogsFromDB(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT LogTime, EventDescription FROM Elevator_Log ORDER BY LogTime DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);

                        dataGridViewLogs.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();
                            dataGridViewLogs.Rows.Add(currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs from DB: " + ex.Message);
            }
        }

        // Delete all logs from DB
        public void DeleteAllLogs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Elevator_Log";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting logs from DB: " + ex.Message);
            }
        }
    }
}
