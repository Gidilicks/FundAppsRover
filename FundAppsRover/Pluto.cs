using System;

namespace FundAppsRover
{
    public class Pluto : ILandingSurface
    {
        public Pluto(int xMaxCoordinate, int yMaxCoordinate)
        {
            this.Width = xMaxCoordinate;
            this.Height = yMaxCoordinate;
        }

        public Pluto(string plutoCoordinates)
        {
            if (string.IsNullOrEmpty(plutoCoordinates))
                throw new ArgumentException();

            this.SplitMessageCoordinates(plutoCoordinates);
        }

        public virtual int Width { get; private set; }
        public virtual int Height { get; private set; }

        private static readonly char MessageSeperator = ' ';

        private void SplitMessageCoordinates(string plutoCoordinates)
        {
            string[] coordinateMessage = plutoCoordinates.Split(Pluto.MessageSeperator);

            int noOfMsgValues = 2;
            int xCoordinateIdx = 0;
            int yCoordinateIdx = 1;

            if (coordinateMessage.Length != noOfMsgValues)
                throw new ArgumentOutOfRangeException();

            this.Width = Convert.ToInt32(coordinateMessage[xCoordinateIdx]);
            this.Height = Convert.ToInt32(coordinateMessage[yCoordinateIdx]);
        }
    }
}
