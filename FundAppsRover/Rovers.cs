using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundAppsRover
{
    public class Rovers : List<IRover>
    {
        public Rovers(ILandingSurface landingSurface) 
        {
            this.LandingSurface = landingSurface;
        }

        public ILandingSurface LandingSurface { get; private set; }

        public void DeployRover(string roverPosition, string roverCommands)
        {
            this.Add(new Rover(this, this.LandingSurface, roverPosition, roverCommands));
        }
    }
}
