using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public class South : IDirection {
        public IDirection TurnLeft()
        {
            return new East();
        }

        public IDirection TurnRight()
        {
            return new West();
        }

        public KeyValuePair<int, int> MoveForward(KeyValuePair<int, int> position)
        {
            var x = position.Key;
            var y = position.Value - 1;
            return new KeyValuePair<int, int>(x,y);
        }
    }
}