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


        public ColorRGB(float R, float G, float B)
        {
            r = R;
            g = G;
            b = B;
        }

        /// <summary>
        /// The red value, between 0 and 255
        /// </summary>
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

        /// <summary>
        /// The green value, between 0 and 255
        /// </summary>
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

        /// <summary>
        /// The blue value, between 0 and 255
        /// </summary>
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