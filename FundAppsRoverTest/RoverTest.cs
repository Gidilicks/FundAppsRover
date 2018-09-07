using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAppsRover;

namespace FundAppsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        int noMovements = 3;
        int roverMoveOne = 0;
        int roverMoveTwo = 1;
        int roverMoveThree = 2;

        ILandingSurface landingSurface = new Pluto("100 100");

        [TestMethod]
        public void RoverMovementTest()
        {
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover moveOne = rovers[roverMoveOne];

            //second movement
            rovers.DeployRover(moveOne.XCoordinate + " " + moveOne.YCoordinate + " " + moveOne.DirectionFacing, "F");
            IRover moveTwo = rovers[roverMoveTwo];

            //third movement
            rovers.DeployRover(moveTwo.XCoordinate + " " + moveTwo.YCoordinate + " " + moveTwo.DirectionFacing, "F");
            IRover moveThree = rovers[roverMoveThree];

            //number of movements
            Assert.IsTrue(rovers.Count == noMovements);

            Assert.IsNotNull(moveOne);
            Assert.IsNotNull(moveTwo);
            Assert.IsNotNull(moveThree);
        }

        [TestMethod]
        public void RoverMovementAndCoordinates()
        {
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover roverOne = rovers[roverMoveOne];

            //second movement
            rovers.DeployRover((roverOne.XCoordinate.ToString() + " " + roverOne.YCoordinate.ToString() + " " + roverOne.DirectionFacing), "FLBR");
            IRover roverTwo = rovers[roverMoveTwo];

            //assert coordinate of first movement from 0 0 North
            Assert.IsTrue((roverOne.XCoordinate.ToString() + " " + roverOne.YCoordinate.ToString() + " " + roverOne.DirectionFacing) == "0 1 N", "Move 1 Coordinate != 0 1 N");
            
            //assert coordinate of second movement from previous coordinate
            Assert.IsTrue((roverTwo.XCoordinate.ToString() + " " + roverTwo.YCoordinate.ToString() + " " + roverTwo.DirectionFacing) == "1 2 N", "Move 2 Coordinate != 1 2 N");
        }
    }
}
