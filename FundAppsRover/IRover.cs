using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundAppsRover
{
    public interface IRover
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        string DirectionFacing { get; set; }
        List<IRover> Moves { get; set; }
    }
}
