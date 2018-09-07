using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundAppsRover
{
    public class Obstacles
    {
        public string[] olist() 
        {
            string[] n = new string[3];
            n[0] = "0 1 N";
            n[1] = "2 2 S";
            n[2] = "1 1 N";
            return n;
        }

    }
}
