using System.Collections.Generic;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class RoverTests
    {
        private Rover _rover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover();
        }

        [Test]
        public void GivenARover_WhenTheRoverIsPlaced_ThenTheStartingPositionIs0x0()
        {
            var position = _rover.Position;

            var result = new KeyValuePair<int, int>(0,0);

            Assert.AreEqual(result, position);
        }

        [Test]
        public void GivenARover_WhenTheRoverIsPlaced_ThenTheStartingPositionIsNorth()
        {
            var direction = _rover.Direction;

            Assert.IsInstanceOf(typeof(North), direction);
        }

        [Test]
        public void GivenARoverFacingNorth_WhenTheRoverTurnsLeft_ThenTheRoverIsNowFacingWest()
        {
            _rover.TurnLeft();

            var direction = _rover.Direction;

            Assert.IsInstanceOf(typeof(West), direction);
        }

        [Test]
        public void GivenARoverFacingNorth_WhenTheRoverTurnsRight_ThenTheRoverIsNowFacingEast()
        {
            _rover.TurnRight();

            Assert.IsInstanceOf(typeof(East), _rover.Direction);
        }

        [Test]
        public void GivenARoverFacingNorth_WhenTheRoverMovesForward1_ThenTheNewPositionIs0x1()
        {
            _rover.MoveForward();

            var newPostition = new KeyValuePair<int, int>(0, 1);

            Assert.AreEqual(newPostition, _rover.Position);
        }

        [Test]
        public void GivenARoverFacingEast_WhenTheRoverMovesForward1_ThenTheNewPositionIs1x0()
        {
            _rover.TurnRight();
            _rover.MoveForward();

            var newPosition = new KeyValuePair<int, int>(1, 0);

            Assert.AreEqual(newPosition, _rover.Position);
        }
    }
}
