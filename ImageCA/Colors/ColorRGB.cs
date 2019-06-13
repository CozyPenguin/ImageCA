using System;

namespace ImageCA.Colors
{
    /// <summary>
    /// A color in the RGB colorspace
    /// </summary>
    public struct ColorRGB
    {
        private float r;
        private float g;
        private float b;


        public ColorRGB(byte R, byte G, byte B)
        {
            r = R;
            g = G;
            b = B;
        }

        public float R
        {
            get
            {
                return (r);
            }
            set
            {
                if (value >= 0 && value <= 255) r = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 255");
            }
        }
        public float G
        {
            get
            {
                return (g);
            }
            set
            {
                if (value >= 0 && value <= 255) g = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 255");
            }
        }
        public float B
        {
            get
            {
                return (b);
            }
            set
            {
                if (value >= 0 && value <= 255) b = value;
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 255");
            }
        }
    }
}