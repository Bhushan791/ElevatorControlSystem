using System;
using System.Drawing;
using System.Windows.Forms;
using ElevatorControlSystem.Core;
using ElevatorControlSystem.UI;

namespace ElevatorControlSystem.States
{
    internal class CloseDoorState : ILiftState
    {
        private bool soundStarted = false; // Track if sound already started

        public void MovingDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MovingUp(Lift lift)
        {
            /* Do Nothing */
        }

        public void OpenDoor(Lift lift)
        {
            /* Do Nothing */
        }

        public void CloseDoor(Lift lift)
        {
            // PLAY DOOR CLOSING SOUND - Only once when doors start closing
            if (!soundStarted)
            {
                lift.MainForm.soundDoorClose?.Play();
                soundStarted = true;
            }

            // Get the Form instance
            Form1 form = lift.MainElevator.FindForm() as Form1;
            if (form == null) return;

            // Find the necessary controls
            PictureBox doorLeft_G = form.Controls.Find("doorLeft_G", true)[0] as PictureBox;
            PictureBox doorRight_G = form.Controls.Find("doorRight_G", true)[0] as PictureBox;
            PictureBox doorLeft_1 = form.Controls.Find("doorLeft_1", true)[0] as PictureBox;
            PictureBox doorRight_1 = form.Controls.Find("doorRight_1", true)[0] as PictureBox;
            Button btn_Open = form.Controls.Find("btn_Open", true)[0] as Button;
            Button btn_Close = form.Controls.Find("btn_Close", true)[0] as Button;

            int doorSpeed = 5;
            bool doorsFullyClosed = false;

            // Get the saved perfect initial positions from Form1
            int targetLeftX = form.InitialDoorLeftX;   // 160 - Perfect closed position
            int targetRightX = form.InitialDoorRightX; // 260 - Perfect closed position

            // Determine which floor we're on (Floor 2 is Top < 100, Floor 1 is Top >= 100)
            if (lift.MainElevator.Top < 100) // Floor 2 (top floor)
            {
                // Check if both doors are at their target positions
                bool leftDoorAtTarget = (doorLeft_1.Left == targetLeftX);
                bool rightDoorAtTarget = (doorRight_1.Left == targetRightX);

                if (!leftDoorAtTarget || !rightDoorAtTarget)
                {
                    // Move left door towards target (160)
                    if (doorLeft_1.Left < targetLeftX)
                    {
                        doorLeft_1.Left += doorSpeed;
                        if (doorLeft_1.Left > targetLeftX)
                            doorLeft_1.Left = targetLeftX;
                    }
                    else if (doorLeft_1.Left > targetLeftX)
                    {
                        doorLeft_1.Left -= doorSpeed;
                        if (doorLeft_1.Left < targetLeftX)
                            doorLeft_1.Left = targetLeftX;
                    }

                    // Move right door towards target (260)
                    if (doorRight_1.Left > targetRightX)
                    {
                        doorRight_1.Left -= doorSpeed;
                        if (doorRight_1.Left < targetRightX)
                            doorRight_1.Left = targetRightX;
                    }
                    else if (doorRight_1.Left < targetRightX)
                    {
                        doorRight_1.Left += doorSpeed;
                        if (doorRight_1.Left > targetRightX)
                            doorRight_1.Left = targetRightX;
                    }
                }
                else
                {
                    // Both doors are exactly at target - fully closed!
                    doorsFullyClosed = true;
                }
            }
            else // Floor 1 (ground floor)
            {
                // Check if both doors are at their target positions
                bool leftDoorAtTarget = (doorLeft_G.Left == targetLeftX);
                bool rightDoorAtTarget = (doorRight_G.Left == targetRightX);

                if (!leftDoorAtTarget || !rightDoorAtTarget)
                {
                    // Move left door towards target (160)
                    if (doorLeft_G.Left < targetLeftX)
                    {
                        doorLeft_G.Left += doorSpeed;
                        if (doorLeft_G.Left > targetLeftX)
                            doorLeft_G.Left = targetLeftX;
                    }
                    else if (doorLeft_G.Left > targetLeftX)
                    {
                        doorLeft_G.Left -= doorSpeed;
                        if (doorLeft_G.Left < targetLeftX)
                            doorLeft_G.Left = targetLeftX;
                    }

                    // Move right door towards target (260)
                    if (doorRight_G.Left > targetRightX)
                    {
                        doorRight_G.Left -= doorSpeed;
                        if (doorRight_G.Left < targetRightX)
                            doorRight_G.Left = targetRightX;
                    }
                    else if (doorRight_G.Left < targetRightX)
                    {
                        doorRight_G.Left += doorSpeed;
                        if (doorRight_G.Left > targetRightX)
                            doorRight_G.Left = targetRightX;
                    }
                }
                else
                {
                    // Both doors are exactly at target - fully closed!
                    doorsFullyClosed = true;
                }
            }

            // Once doors are fully closed, stop the timer and reset the state
            if (doorsFullyClosed)
            {
                lift.CloseDoorTimer.Stop();
                lift.SetState(new IdleState());
                lift.Btn_1.Enabled = true;
                lift.Btn_G.Enabled = true;
                lift.Btn_Call1.Enabled = true;
                lift.Btn_Call2.Enabled = true;

                // Enable and reset button colors
                btn_Open.Enabled = true;
                btn_Close.Enabled = false;
                btn_Open.BackColor = Color.White;
                btn_Close.BackColor = Color.White;

                // Log the event
                form.logEvents("Lift doors fully closed.");
            }
        }
    }
}