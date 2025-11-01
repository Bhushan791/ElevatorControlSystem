
// using System;
// using System.Drawing;
// using ElevatorControlSystem.Core;
// using ElevatorControlSystem.UI;

// namespace ElevatorControlSystem.States
// {
//     internal class MovingUpState : ILiftState
//     {
//         private bool soundStarted = false;
//         private bool cabinDoorShown = false; // NEW! Track if cabin door is visible

//         public void MovingUp(Lift lift)
//         {
//             // SHOW CABIN DOOR (only once when state starts)
//             if (!cabinDoorShown)
//             {
//                 lift.CabinDoor.Visible = true;
//                 cabinDoorShown = true;
//             }

//             // START LIFT MOVING SOUND - Only once when movement begins
//             if (!soundStarted)
//             {
//                 lift.MainForm.soundLiftMoving?.PlayLooping();
//                 soundStarted = true;
//             }

//             // Define the target position for floor 2
//             int floor2Position = 93;
            
//             // Move the elevator up if it hasn't reached the top
//             if (lift.MainElevator.Top > floor2Position)
//             {
//                 lift.MainElevator.Top -= lift.LiftSpeed;
//                 // MOVE CABIN DOOR WITH CABIN!
//                 lift.CabinDoor.Top = lift.MainElevator.Top;
//             }
//             else
//             {
//                 // STOP LIFT MOVING SOUND
//                 lift.MainForm.soundLiftMoving?.Stop();

//                 // HIDE CABIN DOOR when reached destination
//                 lift.CabinDoor.Visible = false;

//                 // Reached the top floor
//                 lift.SetState(new IdleState());
//                 lift.MainElevator.Top = floor2Position;
//                 lift.CabinDoor.Top = floor2Position; // Sync position
//                 lift.LiftTimerUp.Stop();

//                 // Reset button states and update floor display
//                 lift.Btn_G.BackColor = Color.White;
//                 lift.Btn_G.Enabled = true;
//                 lift.Btn_1.Enabled = true;
//                 lift.MainForm.UpdateFloorDisplay(2);

//                 // PLAY ARRIVAL DING SOUND
//                 lift.MainForm.soundLiftArrived?.Play();

//                 // Log that the lift has reached the top
//                 lift.MainForm.logEvents("Lift reached 2nd floor. Doors opening...");

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

//         public void MovingDown(Lift lift) { }
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
    internal class MovingUpState : ILiftState
    {
        private bool soundStarted = false;
        private bool cabinSetup = false;

        public void MovingUp(Lift lift)
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
                lift.MainForm.UpdateFloorDisplay(2);

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