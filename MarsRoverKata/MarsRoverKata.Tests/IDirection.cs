using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();  
        KeyValuePair<int, int> MoveForward(KeyValuePair<int, int> position);
    }
}