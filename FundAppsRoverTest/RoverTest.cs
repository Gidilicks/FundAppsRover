using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAppsRover;

namespace FundAppsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        int noMovements = 1;
        int roverMoveOne = 0;

        ILandingSurface landingSurface = new Pluto("100 100");

        [TestMethod]
        public void RoverMovementTest()
        {
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover moveOne = rovers[roverMoveOne];

            //number of movements
            Assert.IsTrue(rovers.Count == noMovements);

            Assert.IsNotNull(moveOne);
        }

        [TestMethod]
        public void RoverMovementAndCoordinates()
        {
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover roverOne = rovers[roverMoveOne];

            //assert coordinate of first movement from 0 0 North moves 0 2 N because of obstacle at 0 1 N
            Assert.IsTrue((roverOne.XCoordinate.ToString() + " " + roverOne.YCoordinate.ToString() + " " + roverOne.DirectionFacing) == "0 2 N", "Move 1 Coordinate != 0 2 N");

        }
    }
}
