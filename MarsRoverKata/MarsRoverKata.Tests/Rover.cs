using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public class Rover
    {
        public KeyValuePair<int, int> Position { get; set; }

        public IDirection Direction;

        public Rover()
        {
            Direction = new North();
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void MoveForward()
        {
            Position = Direction.MoveForward(Position);
        }
    }
}