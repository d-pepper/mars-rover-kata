using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public class West : IDirection
    {
        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new North();
        }

        public KeyValuePair<int, int> MoveForward(KeyValuePair<int, int> position)
        {
            var x = position.Key - 1;
            var y = position.Value;
            return new KeyValuePair<int, int>(x, y);
        }
    }
}