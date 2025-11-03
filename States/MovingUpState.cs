
using System;
using System.Drawing;
using ElevatorControlSystem.Core;
using ElevatorControlSystem.UI;

namespace ElevatorControlSystem.States
{
    internal class MovingUpState : ILiftState
    {
        private bool soundStarted = false;
        private bool cabinSetup = false;

        public void MovingUp(Lift lift)
        {
            // SETUP CABIN FOR MOVING (only once)
            if (!cabinSetup)
            {
                // SHOW MOVING UP ARROW IN DISPLAY
                lift.MainForm.ShowMovingUp();
                
                // SEND CABIN BEHIND FLOORS!
                lift.MainForm.SendCabinBehindFloors();
                
                // SHOW CABIN DOOR (closed metallic door)
                lift.CabinDoor.Visible = true;
                
                // SHOW CABIN TOO (bluish interior)
                lift.MainElevator.Visible = true;
                
                cabinSetup = true;
            }

            // START LIFT MOVING SOUND
            if (!soundStarted)
            {
                lift.MainForm.soundLiftMoving?.PlayLooping();
                soundStarted = true;
            }

            int floor2Position = 93;
            
            // MOVE UP
            if (lift.MainElevator.Top > floor2Position)
            {
                lift.MainElevator.Top -= lift.LiftSpeed;
                lift.CabinDoor.Top = lift.MainElevator.Top;
            }
            else
            {
                // REACHED DESTINATION!
                lift.MainForm.soundLiftMoving?.Stop();
                
                // BRING CABIN IN FRONT OF FLOORS
                lift.MainForm.BringCabinInFrontOfFloors();
                
                // HIDE CABIN DOOR (so user sees bluish cabin)
                lift.CabinDoor.Visible = false;
                
                // SHOW CABIN
                lift.MainElevator.Visible = true;

                lift.SetState(new IdleState());
                lift.MainElevator.Top = floor2Position;
                lift.CabinDoor.Top = floor2Position;
                lift.LiftTimerUp.Stop();

                lift.Btn_G.BackColor = Color.White;
                lift.Btn_G.Enabled = true;
                lift.Btn_1.Enabled = true;
                
                // SHOW FLOOR NUMBER 2
                lift.MainForm.ShowFloorNumber(2);

                lift.MainForm.soundLiftArrived?.Play();
                lift.MainForm.logEvents("Lift reached 2nd floor. Doors opening...");

                System.Threading.Tasks.Task.Delay(1300).ContinueWith(_ => 
                {
                    lift.MainForm.Invoke((System.Action)(() =>
                    {
                        lift.SetState(new OpenDoorState());
                        lift.OpenDoorTimer.Start();
                        lift.AutoDoorTimer.Start();
                    }));
                });
            }
        }

        public void MovingDown(Lift lift) { }
        public void OpenDoor(Lift lift) { }
        public void CloseDoor(Lift lift) { }
    }
}