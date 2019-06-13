using System;

namespace ImageCA.Colors
{
    /// <summary>
    /// A color in the HSV colorspace
    /// </summary>
    public struct ColorHSV
    {
        private double h;
        private double s;
        private double v;

        /// <summary>
        /// Instatiates a new <c>ColorHSV</c> with the given values
        /// </summary>
        /// <param name="H">The hue ranges from 0° to 360° and represents the color</param>
        /// <param name="S">The saturation ranges from 0 to 1 and represents how saturated the color is</param>
        /// <param name="V">The value renges from 0 to 1 and represents the black tint</param>
        public ColorHSV(double H, double S, double V)
        {
            h = H;
            s = S;
            v = V;
        }

        /// <summary>
        /// The hue ranges from 0° to 360° and represents the color
        /// </summary>
        public double H
        {
            get
            {
                return (h);
            }
            set
            {
                if (value >= -360 && value <= 360) h = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 360");
            }
        }
        /// <summary>
        /// The saturation ranges from 0 to 1 and represents how saturated the color is
        /// </summary>
        public double S
        {
            get
            {
                return (s);
            }
            set
            {
                if (value >= 0 && value <= 1) s = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 1");
            }
        }
        /// <summary>
        /// The value renges from 0 to 1 and represents the black tint
        /// </summary>
        public double V
        {
            get
            {
                return (v);
            }
            set
            {
                if (value >= 0 && value <= 1) v = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 1");
            }
        }
    }
}