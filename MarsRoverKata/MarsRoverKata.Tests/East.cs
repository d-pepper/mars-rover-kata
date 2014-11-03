using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public class East : IDirection
    {
        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return new South();
        }

        public KeyValuePair<int, int> MoveForward(KeyValuePair<int, int> position)
        {
            var x = position.Key + 1;
            var y = position.Value;
            return new KeyValuePair<int, int>(x, y);

        }
    }
}