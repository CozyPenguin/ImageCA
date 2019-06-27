using System;
using System.Collections.Generic;
using System.Text;

namespace ImageCA
{

    /// <summary>
    /// A vector containing 4 values
    /// </summary>
    public struct Vector4d
    {
        /// <summary>
        /// the first value
        /// </summary>
        public double a { get; set; }
        /// <summary>
        /// the second value
        /// </summary>
        public double b { get; set; }
        /// <summary>
        /// the third value
        /// </summary>
        public double c { get; set; }
        /// <summary>
        /// the foruth value
        /// </summary>
        public double d { get; set; }

        /// <summary>
        /// Instantiates a new Vector4 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        /// <param name="d">the fourth value</param>
        public Vector4d(byte a, byte b, byte c, byte d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// Instantiates a new Vector4 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        /// <param name="d">the fourth value</param>
        public Vector4d(short a, short b, short c, short d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// Instantiates a new Vector4 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        /// <param name="d">the fourth value</param>
        public Vector4d(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// Instantiates a new Vector4 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        /// <param name="d">the fourth value</param>
        public Vector4d(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// Instantiates a new Vector4 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        /// <param name="d">the fourth value</param>
        public Vector4d(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">first Vector4</param>
        /// <param name="b">second Vector4</param>
        /// <returns></returns>
        public static Vector4d Average(Vector4d a, Vector4d b)
        {
            Vector4d c = new Vector4d();
            c.a = a.a + b.a / 2;
            c.b = a.b + b.b / 2;
            c.c = a.c + b.c / 2;
            c.d = a.d + b.d / 2;
            return (c);
        }

        /// <summary>
        /// returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">first Vector4</param>
        /// <param name="b">second Vector4</param>
        /// <param name="c">third Vector4</param>
        /// <returns></returns>
        public static Vector4d Average(Vector4d a, Vector4d b, Vector4d c)
        {
            Vector4d d = new Vector4d();
            d.a = a.a + b.a + c.a / 3;
            d.b = a.b + b.b + c.b / 3;
            d.c = a.c + b.c + c.c / 3;
            d.d = a.d + b.d + c.d / 3;
            return (d);
        }

        /// <summary>
        /// returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">first Vector4</param>
        /// <param name="b">second Vector4</param>
        /// <param name="c">third Vector4</param>
        /// <param name="d">fourth Vector4</param>
        /// <returns></returns>
        public static Vector4d Average(Vector4d a, Vector4d b, Vector4d c, Vector4d d)
        {
            Vector4d e = new Vector4d();
            e.a = a.a + b.a + c.a + d.a / 4;
            e.b = a.b + b.b + c.b + d.b / 4;
            e.c = a.c + b.c + c.c + d.c / 4;
            e.d = a.d + b.d + c.d + d.d / 4;
            return (e);
        }

        /// <summary>
        /// Converts the vector to a string
        /// </summary>
        /// <returns>Returns a string of a Vector</returns>
        public override string ToString()
        {
            string output = a + ", " + b + ", " + c + ", " + d;
            return (output);
        }

        /// <summary>
        /// add two <c>Vector4</c> together
        /// </summary>
        /// <param name="a">the first <c>Vector4</c> to add</param>
        /// <param name="b">the second <c>Vector4</c> to add</param>
        /// <returns>Returns the sum of a and b</returns>
        public static Vector4d operator +(Vector4d a, Vector4d b)
        {
            Vector4d c = new Vector4d();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            c.c = a.c + b.c;
            c.d = a.d + b.d;
            return (c);
        }

        /// <summary>
        /// subtract a <c>Vector4</c> from another
        /// </summary>
        /// <param name="a">The <c>Vector4</c> to substract from</param>
        /// <param name="b">The <c>Vector4</c> to substract</param>
        /// <returns>Returns the substraction of a and b</returns>
        public static Vector4d operator -(Vector4d a, Vector4d b)
        {
            Vector4d c = new Vector4d();
            c.a = a.a - b.a;
            c.b = a.b - b.b;
            c.c = a.c - b.c;
            return (c);
        }

        /// <summary>
        /// Multiply two <c>Vector4</c>
        /// </summary>
        /// <param name="a">The first <c>Vector4</c> to multiply</param>
        /// <param name="b">The second <c>Vector4</c> to multiply</param>
        /// <returns>Returns the product of a and b</returns>
        public static Vector4d operator *(Vector4d a, Vector4d b)
        {
            Vector4d c = new Vector4d();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            c.c = a.c + b.c;
            c.d = a.d + b.d;
            return (c);
        }

        /// <summary>
        /// Divide a <c>Vector4</c> through another
        /// </summary>
        /// <param name="a">The first <c>Vector4</c></param>
        /// <param name="b">The <c>Vector4</c> to divide thourght</param>
        /// <returns>Returns the division of a and b</returns>
        public static Vector4d operator /(Vector4d a, Vector4d b)
        {
            Vector4d c = new Vector4d();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            c.c = a.c + b.c;
            c.d = a.d + b.d;
            return (c);
        }
    }
}

