using System;
using System.Drawing;
using ElevatorControlSystem.Core;  // ADD THIS LINE
using ElevatorControlSystem.UI;    // ADD THIS LINE

namespace ElevatorControlSystem.States
{
    internal class MovingUpState : ILiftState
    {
        public void MovingUp(Lift lift)
        {
            // Define the target position for floor 2 (adjust this value to fit properly)
            int floor2Position = 93; // Change this to 85, 90, or whatever fits best visually
            
            // Move the elevator up if it hasn't reached the top
            if (lift.MainElevator.Top > floor2Position)
            {
                lift.MainElevator.Top -= lift.LiftSpeed;
            }
            else
            {
                // Reached the top floor
                lift.SetState(new IdleState());
                lift.MainElevator.Top = floor2Position; // Set exact position
                lift.LiftTimerUp.Stop();

                // Reset button states and update floor display
                lift.Btn_G.BackColor = Color.White;
                lift.Btn_G.Enabled = true;
                lift.Btn_1.Enabled = true;
                lift.MainForm.UpdateFloorDisplay(2);

                // Log that the lift has reached the top
                lift.MainForm.logEvents("Lift reached 2nd floor. Doors opening...");

                // Start the door opening process
                lift.SetState(new OpenDoorState());
                lift.OpenDoorTimer.Start();

                // Start the auto door close timer
                lift.AutoDoorTimer.Start();
            }
        }

        // Define other state methods with no implementation
        public void MovingDown(Lift lift) { /* Do nothing */ }
        public void OpenDoor(Lift lift) { /* Do nothing */ }
        public void CloseDoor(Lift lift) { /* Do nothing */ }
    }
}