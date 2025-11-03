


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ElevatorControlSystem.States;
using ElevatorControlSystem.UI;

namespace ElevatorControlSystem.Core
{
    internal class Lift
    {
        public ILiftState _CurrentState;

        public PictureBox MainElevator;
        public PictureBox CabinDoor;
        public Button Btn_1;
        public Button Btn_G;
        public Button Btn_Call1;
        public Button Btn_Call2;
        public int FormSize;
        public int LiftSpeed;
        public System.Windows.Forms.Timer LiftTimerUp;
        public System.Windows.Forms.Timer LiftTimerDown;
        public System.Windows.Forms.Timer OpenDoorTimer;
        public System.Windows.Forms.Timer CloseDoorTimer;
        public System.Windows.Forms.Timer AutoDoorTimer;
        public Form1 MainForm;

        // ADD THIS PROPERTY TO TRACK CURRENT FLOOR
        public int CurrentFloor { get; set; } = 1; // Start at Ground Floor (Floor 1)

        public Lift(
            PictureBox mainElevator,
            PictureBox cabinDoor,
            Button btn_1,
            Button btn_G,
            Button btnCall1,
            Button btnCall2,
            int formSize,
            int liftSpeed,
            System.Windows.Forms.Timer liftTimerUp,
            System.Windows.Forms.Timer liftTimerDown,
            System.Windows.Forms.Timer openDoorTimer,
            System.Windows.Forms.Timer closeDoorTimer,
            System.Windows.Forms.Timer autoDoorTimer,
            Form1 form
        )
        {
            MainElevator = mainElevator;
            CabinDoor = cabinDoor;
            Btn_1 = btn_1;
            Btn_G = btn_G;
            Btn_Call1 = btnCall1;
            Btn_Call2 = btnCall2;
            FormSize = formSize;
            LiftSpeed = liftSpeed;
            LiftTimerUp = liftTimerUp;
            LiftTimerDown = liftTimerDown;
            OpenDoorTimer = openDoorTimer;
            CloseDoorTimer = closeDoorTimer;
            AutoDoorTimer = autoDoorTimer;
            MainForm = form;

            // Set initial state as IdleState
            _CurrentState = new IdleState();
        }

        public void SetState(ILiftState state)
        {
            _CurrentState = state;
        }

        public void MovingUp()
        {
            _CurrentState.MovingUp(this);
        }

        public void MovingDown()
        {
            _CurrentState.MovingDown(this);
        }

        public void OpenDoor()
        {
            _CurrentState.OpenDoor(this);
        }

        public void CloseDoor()
        {
            _CurrentState.CloseDoor(this);
        }
    }
}