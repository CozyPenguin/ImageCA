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

        /// <summary>
        /// initialize a new ColorRGB with the given values
        /// </summary>
        /// <param name="r">the red value ranging from 0 to 255</param>
        /// <param name="g">the green value ranging from 0 to 255</param>
        /// <param name="b">the blue value ranging from 0 to 255</param>
        public ColorRGB(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
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