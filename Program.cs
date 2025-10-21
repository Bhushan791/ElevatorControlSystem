using System;
using System.Windows.Forms;
using ElevatorControlSystem.UI;  // <-- add this line

namespace ElevatorControlSystem
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

