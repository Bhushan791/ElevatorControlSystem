using System;
using System.Drawing;
using ElevatorControlSystem.Core;
using ElevatorControlSystem.UI;

namespace ElevatorControlSystem.States
{
    internal class MovingUpState : ILiftState
    {
        private bool soundStarted = false; // Track if sound already started

        public void MovingUp(Lift lift)
        {
            // START LIFT MOVING SOUND - Only once when movement begins
            if (!soundStarted)
            {
                lift.MainForm.soundLiftMoving?.PlayLooping(); // Loop the motor sound
                soundStarted = true;
            }

            // Define the target position for floor 2
            int floor2Position = 93;
            
            // Move the elevator up if it hasn't reached the top
            if (lift.MainElevator.Top > floor2Position)
            {
                lift.MainElevator.Top -= lift.LiftSpeed;
            }
            else
            {
                // STOP LIFT MOVING SOUND
                lift.MainForm.soundLiftMoving?.Stop();

                // Reached the top floor
                lift.SetState(new IdleState());
                lift.MainElevator.Top = floor2Position; // Set exact position
                lift.LiftTimerUp.Stop();

                // Reset button states and update floor display
                lift.Btn_G.BackColor = Color.White;
                lift.Btn_G.Enabled = true;
                lift.Btn_1.Enabled = true;
                lift.MainForm.UpdateFloorDisplay(2);

                // PLAY ARRIVAL DING SOUND
                lift.MainForm.soundLiftArrived?.Play();

                // Log that the lift has reached the top
                lift.MainForm.logEvents("Lift reached 2nd floor. Doors opening...");

                // DELAY BEFORE OPENING DOORS - Let the full "ding dong" sound play (1 second)
                System.Threading.Tasks.Task.Delay(1300).ContinueWith(_ => 
                {
                    lift.MainForm.Invoke((System.Action)(() =>
                    {
                        // Start the door opening process after delay
                        lift.SetState(new OpenDoorState());
                        lift.OpenDoorTimer.Start();
                        lift.AutoDoorTimer.Start();
                    }));
                });
            }
        }

        // Define other state methods with no implementation
        public void MovingDown(Lift lift) { /* Do nothing */ }
        public void OpenDoor(Lift lift) { /* Do nothing */ }
        public void CloseDoor(Lift lift) { /* Do nothing */ }
    }
}