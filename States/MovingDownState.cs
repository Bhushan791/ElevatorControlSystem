// using System;
// using System.Drawing;
// using ElevatorControlSystem.Core;
// using ElevatorControlSystem.UI;

// namespace ElevatorControlSystem.States
// {
//     internal class MovingDownState : ILiftState
//     {
//         private bool soundStarted = false;
//         private bool cabinDoorShown = false; // NEW! Track if cabin door is visible

//         public void MovingDown(Lift lift)
//         {
//             // SHOW CABIN DOOR (only once when state starts)
//             if (!cabinDoorShown)
//             {
//                 lift.CabinDoor.Visible = true;
//                 cabinDoorShown = true;
//             }

//             // START LIFT MOVING SOUND
//             if (!soundStarted)
//             {
//                 lift.MainForm.soundLiftMoving?.PlayLooping();
//                 soundStarted = true;
//             }

//             if (lift.MainElevator.Top == 0 || lift.MainElevator.Bottom < lift.FormSize - 30)
//             {
//                 lift.MainElevator.Top += lift.LiftSpeed;
//                 // MOVE CABIN DOOR WITH CABIN!
//                 lift.CabinDoor.Top = lift.MainElevator.Top;
//             }
//             else
//             {
//                 // STOP LIFT MOVING SOUND
//                 lift.MainForm.soundLiftMoving?.Stop();

//                 // HIDE CABIN DOOR when reached destination
//                 lift.CabinDoor.Visible = false;

//                 // Once it reaches the bottom, transition to IdleState
//                 lift.SetState(new IdleState());
//                 lift.MainElevator.Top = lift.FormSize - 20 - lift.MainElevator.Height;
//                 lift.CabinDoor.Top = lift.MainElevator.Top; // Sync position

//                 lift.LiftTimerDown.Stop();

//                 lift.Btn_1.BackColor = Color.White;
//                 lift.Btn_1.Enabled = true;
//                 lift.Btn_G.Enabled = true;

//                 lift.MainForm.UpdateFloorDisplay(1);

//                 // PLAY ARRIVAL DING SOUND
//                 lift.MainForm.soundLiftArrived?.Play();

//                 // Log that the lift reached the ground floor
//                 lift.MainForm.logEvents("Lift reached ground floor. Doors opening...");

//                 // DELAY BEFORE OPENING DOORS
//                 System.Threading.Tasks.Task.Delay(1300).ContinueWith(_ => 
//                 {
//                     lift.MainForm.Invoke((System.Action)(() =>
//                     {
//                         lift.SetState(new OpenDoorState());
//                         lift.OpenDoorTimer.Start();
//                         lift.AutoDoorTimer.Start();
//                     }));
//                 });
//             }
//         }

//         public void MovingUp(Lift lift) { }
//         public void OpenDoor(Lift lift) { }
//         public void CloseDoor(Lift lift) { }
//     }
// }



using System;
using System.Drawing;
using ElevatorControlSystem.Core;
using ElevatorControlSystem.UI;

namespace ElevatorControlSystem.States
{
    internal class MovingDownState : ILiftState
    {
        private bool soundStarted = false;
        private bool cabinSetup = false;

        public void MovingDown(Lift lift)
        {
            // SETUP CABIN FOR MOVING (only once)
            if (!cabinSetup)
            {
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

            // MOVE DOWN
            if (lift.MainElevator.Top == 0 || lift.MainElevator.Bottom < lift.FormSize - 30)
            {
                lift.MainElevator.Top += lift.LiftSpeed;
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
                lift.MainElevator.Top = lift.FormSize - 20 - lift.MainElevator.Height;
                lift.CabinDoor.Top = lift.MainElevator.Top;

                lift.LiftTimerDown.Stop();

                lift.Btn_1.BackColor = Color.White;
                lift.Btn_1.Enabled = true;
                lift.Btn_G.Enabled = true;

                lift.MainForm.UpdateFloorDisplay(1);
                lift.MainForm.soundLiftArrived?.Play();
                lift.MainForm.logEvents("Lift reached ground floor. Doors opening...");

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

        public void MovingUp(Lift lift) { }
        public void OpenDoor(Lift lift) { }
        public void CloseDoor(Lift lift) { }
    }
}