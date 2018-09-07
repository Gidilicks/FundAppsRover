using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAppsRover;

namespace FundAppsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void DeployRover()
        {
            int noMovements = 1;
            int roverMoveOne = 0;

            ILandingSurface landingSurface = new Pluto("10 10");
            Rovers rovers = new Rovers(landingSurface);

            //first movement from 0, 0 facing North
            rovers.DeployRover("0 0 N", "F");
            IRover moveOne = rovers[roverMoveOne];

            Assert.IsTrue(rovers.Count == noMovements);

            Assert.IsNotNull(moveOne);
        }
    }
}
