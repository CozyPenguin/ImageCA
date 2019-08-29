using System;

namespace ImageCA.Colors
{
    /// <summary>
    /// A color in the HSV colorspace
    /// </summary>
    public struct ColorCIEXYZ
    {
        private double x;
        private double y;
        private double z;

        /// <summary>
        /// Instatiates a new <c>ColorCIEXYZ</c> with the given values
        /// </summary>
        /// <param name="X">The hue ranges from 0° to 360° and represents the color</param>
        /// <param name="Y">The saturation ranges from 0 to 1 and represents how saturated the color is</param>
        /// <param name="Z">The value renges from 0 to 1 and represents the black tint</param>
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

        /// <summary>
        /// The hue ranges from 0° to 360° and represents the color
        /// </summary>
        public double X
        {
            get
            {
                return (x);
            }
            set
            {
                if (value >= -360 && value <= 360) x = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 360");
            }
        }
        /// <summary>
        /// The saturation ranges from 0 to 1 and represents how saturated the color is
        /// </summary>
        public double Y
        {
            get
            {
                return (y);
            }
            set
            {
                if (value >= 0 && value <= 1) y = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 1");
            }
        }
        /// <summary>
        /// The value renges from 0 to 1 and represents the black tint
        /// </summary>
        public double Z
        {
            get
            {
                return (z);
            }
            set
            {
                if (value >= 0 && value <= 1) z = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 1");
            }
        }
    }
}