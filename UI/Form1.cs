using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using ElevatorControlSystem.Core;
using ElevatorControlSystem.Data;
using ElevatorControlSystem.States;

namespace ElevatorControlSystem.UI
{
    public partial class Form1 : Form
    {
        bool isClosing = false;
        bool isOpening = false;

        int doorMaxOpenWidth;
        int doorSpeed = 5;
        int liftSpeed = 5;

        public int InitialDoorLeftX = 160;
        public int InitialDoorRightX = 260;

        private Lift lift;
        DataTable dt = new DataTable();
        DBContext dbContext = new DBContext();

        // BackgroundWorker for database operations
        private BackgroundWorker bgWorker;

        // SOUND PLAYERS
        public SoundPlayer soundButtonPress;
        public SoundPlayer soundLiftMoving;
        public SoundPlayer soundLiftArrived;
        public SoundPlayer soundDoorOpen;
        public SoundPlayer soundDoorClose;

        public Form1()
        {
            InitializeComponent();
            //  this.WindowState = FormWindowState.Maximized;  ///maximised window

            // Initialize BackgroundWorker
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            // INITIALIZE SOUNDS
            InitializeSounds();

            lift = new Lift(mainElevator, cabinDoor, btn_1, btn_G, btnCall1, btnCall2, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown, openDoorTimer, closeDoorTimer, autoDoorTimer, this);

            doorMaxOpenWidth = mainElevator.Width / 2 + 80;

            dataGridViewLogs.ColumnCount = 2;
            dataGridViewLogs.Columns[0].Name = "Time";
            dataGridViewLogs.Columns[1].Name = "Events";

            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");

            autoDoorTimer.Interval = 1000;
            autoDoorTimer.Tick += autoDoorTimer_Tick;
        }

        // Initialize all sound effects
        private void InitializeSounds()
        {
            try
            {
                soundButtonPress = new SoundPlayer("Resources/button_press.wav");
                soundLiftMoving = new SoundPlayer("Resources/lift_moving.wav");
                soundLiftArrived = new SoundPlayer("Resources/lift_arrived.wav");
                soundDoorOpen = new SoundPlayer("Resources/door_open.wav");
                soundDoorClose = new SoundPlayer("Resources/door_close.wav");

                // Load sounds into memory for faster playback
            
                soundLiftMoving.Load();
                soundLiftArrived.Load();
                soundDoorOpen.Load();
                soundDoorClose.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sound files: {ex.Message}\nSounds will be disabled.", 
                    "Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // BackgroundWorker DoWork - Runs on background thread
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LogData logData = (LogData)e.Argument;

            // Create temporary DataTable for this log entry
            DataTable tempDt = new DataTable();
            tempDt.Columns.Add("LogTime");
            tempDt.Columns.Add("EventDescription");

            DataRow row = tempDt.NewRow();
            row["LogTime"] = logData.Time;
            row["EventDescription"] = logData.Message;
            tempDt.Rows.Add(row);

            // Insert into database
            dbContext.InsertLogsIntoDB(tempDt);
        }

        // BackgroundWorker Completed - Runs on UI thread
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show($"Error saving log: {e.Error.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            // Add to DataTable and DataGridView
            dt.Rows.Add(currentTime, message);
            dataGridViewLogs.Rows.Add(currentTime, message);

            // Save to database using BackgroundWorker (non-blocking)
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync(new LogData { Time = currentTime, Message = message });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int doorDownAdjustment = 1;

            doorLeft_G.Top += doorDownAdjustment;
            doorRight_G.Top += doorDownAdjustment;

            InitialDoorLeftX = doorLeft_G.Left;
            InitialDoorRightX = doorRight_G.Left;

            dbContext.LoadLogsFromDB(dt, dataGridViewLogs);
        }

        public void UpdateFloorDisplay(int floor)
        {
            lblFloorDisplay.Text = floor.ToString();
        }

























// SEND CABIN BEHIND FLOORS (when moving)
public void SendCabinBehindFloors()
{
    mainElevator.SendToBack();
    cabinDoor.SendToBack();
    mainElevator.SendToBack();
    
    pictureBox1.BringToFront();
    pictureBox2.BringToFront();
    
    // BRING LABELS TO FRONT so they're not covered
    label1.BringToFront();
    label2.BringToFront();
    
    doorLeft_G.BringToFront();
    doorRight_G.BringToFront();
    doorLeft_1.BringToFront();
    doorRight_1.BringToFront();
}

// BRING CABIN IN FRONT OF FLOORS (when stopped)
public void BringCabinInFrontOfFloors()
{
    pictureBox1.SendToBack();
    pictureBox2.SendToBack();
    
    mainElevator.BringToFront();
    cabinDoor.BringToFront();
    
    // BRING LABELS TO FRONT here too
    label1.BringToFront();
    label2.BringToFront();
    
    doorLeft_G.BringToFront();
    doorRight_G.BringToFront();
    doorLeft_1.BringToFront();
    doorRight_1.BringToFront();
}




















        public void btn_1_click(object sender, EventArgs e)
        {
            // BUTTON PRESS SOUND REMOVED

            lift.SetState(new MovingUpState());
            btn_1.BackColor = Color.LightGreen;
            btnCall1.BackColor = Color.White;
            btnCall1.Enabled = false;
            lift.LiftTimerUp.Start();
            btn_G.Enabled = false;
            logEvents("Lift is going up!");
        }

        public void btn_G_click(object sender, EventArgs e)
        {
            // BUTTON PRESS SOUND REMOVED

            lift.SetState(new MovingDownState());
            btn_G.BackColor = Color.LightGreen;
            btnCall2.BackColor = Color.White;
            btnCall2.Enabled = false;
            btn_1.Enabled = false;
            lift.LiftTimerDown.Start();
            logEvents("Lift is going down!");
        }

        public void liftTimerUp_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
        }

        public void liftTimerDown_Tick(object sender, EventArgs e)
        {
            lift.MovingDown();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            // BUTTON PRESS SOUND REMOVED

            isOpening = true;
            isClosing = false;
            btn_Close.Enabled = false;
            btn_Open.BackColor = Color.LightGreen;
            btn_Close.BackColor = Color.White;
            lift.SetState(new OpenDoorState());
            openDoorTimer.Start();
            logEvents("Lift door opening...");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // BUTTON PRESS SOUND REMOVED

            btn_Open.BackColor = Color.White;
            isOpening = false;
            isClosing = true;
            btn_Open.Enabled = false;
            btn_Close.BackColor = Color.LightGreen;
            lift.SetState(new CloseDoorState());
            closeDoorTimer.Start();
            logEvents("Lift door closing...");
        }

        private void closeDoorTimer_Tick(object sender, EventArgs e)
        {
            lift.CloseDoor();
        }

        private void openDoorTimer_Tick(object sender, EventArgs e)
        {
            lift.OpenDoor();
        }

        private void btnCall2_Click(object sender, EventArgs e)
        {
            // BUTTON PRESS SOUND REMOVED

            btnCall1.BackColor = Color.White;
            lift.SetState(new MovingUpState());
            btnCall2.BackColor = Color.LightGreen;
            lift.LiftTimerUp.Start();
        }

        private void btnCall1_Click(object sender, EventArgs e)
        {
            // BUTTON PRESS SOUND REMOVED

            btnCall2.BackColor = Color.White;
            lift.SetState(new MovingDownState());
            btnCall1.BackColor = Color.LightGreen;
            lift.LiftTimerDown.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete all logs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dbContext.DeleteAllLogs();
                dt.Rows.Clear();
                dataGridViewLogs.Rows.Clear();
                MessageBox.Show("All logs have been deleted");
            }
            else
            {
                MessageBox.Show("Deletion canceled.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autoDoorTimer_Tick(object sender, EventArgs e)
        {
            autoDoorTimer.Stop();

            if (btn_Close.Enabled && lift._CurrentState is IdleState)
            {
                isOpening = false;
                isClosing = true;
                btn_Open.Enabled = false;
                btn_Close.BackColor = Color.LightGreen;
                btn_Open.BackColor = Color.White;
                lift.SetState(new CloseDoorState());
                closeDoorTimer.Start();
                logEvents("Lift door closing automatically...");
            }
        }

        // Helper class for passing log data to BackgroundWorker
        private class LogData
        {
            public string Time { get; set; }
            public string Message { get; set; }
        }
    }
}

