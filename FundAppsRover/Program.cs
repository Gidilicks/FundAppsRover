using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundAppsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            ILandingSurface landingSurface = new Pluto("100 100");
            Rovers rovers = new Rovers(landingSurface);



            rovers.DeployRover("0 0 N", "F");
            int roverOneId = 0;
            IRover roverOne = rovers[roverOneId];

            rovers.DeployRover("0 0 N", "B");
            int roverTwoId = 1;
            IRover roverTwo = rovers[roverTwoId];

            Console.WriteLine("Input:");
            Console.WriteLine(roverOne.XCoordinate.ToString() + "," + roverOne.YCoordinate.ToString() + "," + roverOne.DirectionFacing.ToString());
            Console.WriteLine(roverTwo.XCoordinate.ToString() + "," + roverTwo.YCoordinate.ToString() + "," + roverTwo.DirectionFacing.ToString());
            Console.Write("Press <enter> to exit...");
            Console.ReadLine();
        }
    }
}
