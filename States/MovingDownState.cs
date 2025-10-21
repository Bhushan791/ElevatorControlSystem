using System;
using System.Drawing;
using ElevatorControlSystem.Core;  // ADD THIS LINE
using ElevatorControlSystem.UI;    // ADD THIS LINE

namespace ElevatorControlSystem.States
{
    internal class MovingDownState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            if (lift.MainElevator.Top == 0 || lift.MainElevator.Bottom < lift.FormSize - 30)
            {
                lift.MainElevator.Top += lift.LiftSpeed;
            }
            else
            {
                // Once it reaches the bottom, transition to IdleState
                lift.SetState(new IdleState());
                lift.MainElevator.Top = lift.FormSize - 20 - lift.MainElevator.Height;

                lift.LiftTimerDown.Stop();  // Stop the timer at ground floor

                lift.Btn_1.BackColor = Color.White;
                lift.Btn_1.Enabled = true;  // Re-enable the 1st floor button
                lift.Btn_G.Enabled = true;  // Enable other controls

                lift.MainForm.UpdateFloorDisplay(1);

                // Log that the lift reached the ground floor
                lift.MainForm.logEvents("Lift reached ground floor. Doors opening...");

                // Transition to OpenDoorState and start the timers
                lift.SetState(new OpenDoorState());
                lift.OpenDoorTimer.Start();
                lift.AutoDoorTimer.Start();  // Auto door close timer
            }
        }

        public void MovingUp(Lift lift)
        {
            // Do Nothing
        }

        public void OpenDoor(Lift lift)
        {
            // Do Nothing
        }

        public void CloseDoor(Lift lift)
        {
            // Do Nothing
        }
    }
}
