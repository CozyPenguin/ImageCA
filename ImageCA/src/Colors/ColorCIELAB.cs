using System;

namespace ImageCA.Colors
{
    /// <summary>
    /// A color in the CIELAB colorspace
    /// </summary>
    public struct ColorCIELAB
    {
        private double l;
        private double a;
        private double b;

        /// <summary>
        /// Instatiates a new <c>ColorCIELAB</c> with the given values
        /// </summary>
        public ColorCIELAB(double L, double A, double B)
        {
            l = L;
            a = A;
            b = B;
        }


        public double L
        {
            get
            {
                return (l);
            }
        }

        public double A
        {
            get
            {
                return (a);
            }
        }

        public double B
        {
            get
            {
                return (b);
            }
        }
    }
}