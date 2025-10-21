using System;
using ElevatorControlSystem.Core;  // ADD THIS LINE

namespace ElevatorControlSystem.States
{
    // Define the contract for the lift states
    internal interface ILiftState
    {
        // Action when the lift is requested to move up
        void MovingUp(Lift lift);

        // Action when the lift is requested to move down
        void MovingDown(Lift lift);

        // Action when the lift is requested to open the doors
        void OpenDoor(Lift lift);

        // Action when the lift is requested to close the doors
        void CloseDoor(Lift lift);
    }
}
