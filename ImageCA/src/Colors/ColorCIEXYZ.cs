using System;

namespace ImageCA.Colors
{
    /// <summary>
    /// A color in the CIEXYZ colorspace
    /// </summary>
    public struct ColorCIEXYZ
    {
        private double x;
        private double y;
        private double z;

        /// <summary>
        /// Instatiates a new <c>ColorCIEXYZ</c> with the given values
        /// </summary>
        public ColorCIEXYZ(double X, double Y, double Z)
        {
            if (1 == X + Y + Z)
            {
                x = X;
                y = Y;
                z = Z;
            }
            else throw new Exception("Color values not correct");
        }


        public double X
        {
            get
            {
                return (x);
            }
        }

        public double Y
        {
            get
            {
                return (y);
            }
        }

        public double Z
        {
            get
            {
                return (z);
            }
        }
    }
}