using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public class West : IDirection
    {
        public IDirection TurnLeft()
        {
            throw new System.NotImplementedException();
        }

        public IDirection TurnRight()
        {
            throw new System.NotImplementedException();
        }

        public KeyValuePair<int, int> MoveForward(KeyValuePair<int, int> position)
        {
            throw new System.NotImplementedException();
        }
    }
}