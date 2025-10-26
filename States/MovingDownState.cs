using System;
using System.Drawing;
using ElevatorControlSystem.Core;
using ElevatorControlSystem.UI;

namespace ElevatorControlSystem.States
{
    internal class MovingDownState : ILiftState
    {
        private bool soundStarted = false; // Track if sound already started

        public void MovingDown(Lift lift)
        {
            // START LIFT MOVING SOUND - Only once when movement begins
            if (!soundStarted)
            {
                lift.MainForm.soundLiftMoving?.PlayLooping(); // Loop the motor sound
                soundStarted = true;
            }

            if (lift.MainElevator.Top == 0 || lift.MainElevator.Bottom < lift.FormSize - 30)
            {
                lift.MainElevator.Top += lift.LiftSpeed;
            }
            else
            {
                // STOP LIFT MOVING SOUND
                lift.MainForm.soundLiftMoving?.Stop();

                // Once it reaches the bottom, transition to IdleState
                lift.SetState(new IdleState());
                lift.MainElevator.Top = lift.FormSize - 20 - lift.MainElevator.Height;

                lift.LiftTimerDown.Stop();  // Stop the timer at ground floor

                lift.Btn_1.BackColor = Color.White;
                lift.Btn_1.Enabled = true;  // Re-enable the 1st floor button
                lift.Btn_G.Enabled = true;  // Enable other controls

                lift.MainForm.UpdateFloorDisplay(1);

                // PLAY ARRIVAL DING SOUND
                lift.MainForm.soundLiftArrived?.Play();

                // Log that the lift reached the ground floor
                lift.MainForm.logEvents("Lift reached ground floor. Doors opening...");

                // DELAY BEFORE OPENING DOORS - Let the full "ding dong" sound play (1 second)
                System.Threading.Tasks.Task.Delay(1300).ContinueWith(_ => 
                {
                    lift.MainForm.Invoke((System.Action)(() =>
                    {
                        // Transition to OpenDoorState and start the timers after delay
                        lift.SetState(new OpenDoorState());
                        lift.OpenDoorTimer.Start();
                        lift.AutoDoorTimer.Start();
                    }));
                });
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