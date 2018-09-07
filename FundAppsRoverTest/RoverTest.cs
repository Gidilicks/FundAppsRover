using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAppsRover;

namespace FundAppsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        int roverMoveOne = 0;
        int roverMoveTwo = 1;

        ILandingSurface landingSurface = new Pluto("100 100");

        [TestMethod]
        public void RoverMovementTest()
        {
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover moveOne = rovers[roverMoveOne];


            Assert.IsNotNull(moveOne);
        }

        [TestMethod]
        public void RoverMovementAndCoordinates()
        {
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover roverOne = rovers[roverMoveOne];

            rovers.DeployRover("0 0 N", "FF");
            IRover roverTwo = rovers[roverMoveTwo];

            //assert coordinate of first movement from 0 0 North for F command
            Assert.IsTrue((roverOne.XCoordinate.ToString() + " " + roverOne.YCoordinate.ToString() + " " + roverOne.DirectionFacing) == "0 1 N", "Move 1 Coordinate != 0 1 N");

            ////assert coordinate of first movement from 0 0 North for FF command
            Assert.IsTrue((roverTwo.XCoordinate.ToString() + " " + roverTwo.YCoordinate.ToString() + " " + roverTwo.DirectionFacing) == "0 2 N", "Obstacle at 0 2 N");

            Assert.IsTrue((roverTwo.XCoordinate.ToString() + " " + roverTwo.YCoordinate.ToString() + " " + roverTwo.DirectionFacing) == "0 3 N", "Move 2 Coordinate != 0 3 N");
        }
    }
}
