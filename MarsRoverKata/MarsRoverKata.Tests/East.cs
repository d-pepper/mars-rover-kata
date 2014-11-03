using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public class East : IDirection
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
            var x = position.Key + 1;
            var y = position.Value;
            return new KeyValuePair<int, int>(x, y);

        }
    }
}