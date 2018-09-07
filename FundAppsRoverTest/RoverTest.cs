using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAppsRover;

namespace FundAppsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void RoverMovementTest()
        {
            int noMovements = 3;
            int roverMoveOne = 0;
            int roverMoveTwo = 1;
            int roverMoveThree = 2;

            ILandingSurface landingSurface = new Pluto("100 100");
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
    }
}
