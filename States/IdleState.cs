using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorControlSystem.Core;  // ADD THIS LINE

namespace ElevatorControlSystem.States
{
	internal class IdleState : ILiftState
	{
		public void MovingDown(Lift lift)
		{
		
		}

		public void MovingUp(Lift lift)
		{
			
		}

		public void OpenDoor(Lift lift)
		{

		}

		public void CloseDoor(Lift lift)
		{
		}
	}
}
