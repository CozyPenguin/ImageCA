﻿namespace ImageCA.Vectors
{
    /// <summary>
    /// A vector containing 3 int values
    /// </summary>
    [System.Serializable]
    public struct Vector2d : IVector2
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
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2d(int a, int b)
        {
            this.a = a;
            this.b = b;

        }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2d(byte a, byte b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2d(short a, short b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2d(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2d(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector3</param>
        /// <param name="b">The second Vector3</param>
        /// <returns>Returns the arithmetic mean of the vectors</returns>
        public static Vector2d Average(Vector2d a, Vector2d b)
        {
            Vector2d c = new Vector2d();
            c.a = a.a + b.a / 2;
            c.b = a.b + b.b / 2;
            return (c);
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector3</param>
        /// <param name="b">The second Vector3</param>
        /// <param name="c">The third Vector3</param>
        /// <returns>returns the arithmetic mean of the vectors</returns>
        public static Vector2d Average(Vector2d a, Vector2d b, Vector2d c)
        {
            Vector2d d = new Vector2d();
            d.a = a.a + b.a + c.a / 3;
            d.b = a.b + b.b + c.b / 3;
            return (d);
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector3</param>
        /// <param name="b">The second Vector3</param>
        /// <param name="c">The third Vector3</param>
        /// <param name="d">The fourth Vector3</param>
        /// <returns>returns the arithmetic mean of the vectors</returns>
        public static Vector2d Average(Vector2d a, Vector2d b, Vector2d c, Vector2d d)
        {
            Vector2d e = new Vector2d();
            e.a = a.a + b.a + c.a + d.a / 4;
            e.b = a.b + b.b + c.b + d.b / 4;
            return (e);
        }

        /// <summary>
        /// Converts the <c>Vector3</c> to a <c>Vector4</c>
        /// <c>Vector3</c> is located at the beginning of <c>Vector4</c>
        /// </summary>
        /// <param name="c">the fourth parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector3</returns>
        public Vector3d ToVector4Beginning(double c)
        {
            Vector3d vector = new Vector3d(a, b, c);
            return (vector);
        }

        /// <summary>
        /// Converts the <c>Vector3</c> to a <c>Vector4</c>
        /// <c>Vector3</c> is located at the end of <c>Vector4</c>
        /// </summary>
        /// <param name="a">the first parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector3</returns>

        public Vector3d ToVector4End(double a)
        {
            Vector3d vector = new Vector3d(a, this.a, b);
            return (vector);
        }

        /// <summary>
        /// Converts the vector to a string
        /// </summary>
        /// <returns>Returns a string of a Vector</returns>
        public override string ToString()
        {
            string output = a + ", " + b;
            return (output);
        }

        /// <summary>
        /// add two <c>Vector3</c> together
        /// </summary>
        /// <param name="a">the first <c>Vector3</c> to add</param>
        /// <param name="b">the second <c>Vector3</c> to add</param>
        /// <returns>Returns the sum of a and b</returns>
        public static Vector2d operator +(Vector2d a, Vector2d b)
        {
            Vector2d c = new Vector2d();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            return (c);
        }

        /// <summary>
        /// subtract a <c>Vector3</c> from another
        /// </summary>
        /// <param name="a">The <c>Vector3</c> to substract from</param>
        /// <param name="b">The <c>Vector3</c> to substract</param>
        /// <returns>Returns the substraction of a and b</returns>
        public static Vector2d operator -(Vector2d a, Vector2d b)
        {
            Vector2d c = new Vector2d();
            c.a = a.a - b.a;
            c.b = a.b - b.b;
            return (c);
        }

        /// <summary>
        /// Multiply two <c>Vector3</c>
        /// </summary>
        /// <param name="a">The first <c>Vector3</c> to multiply</param>
        /// <param name="b">The second <c>Vector3</c> to multiply</param>
        /// <returns>Returns the product of a and b</returns>
        public static Vector2d operator *(Vector2d a, Vector2d b)
        {
            Vector2d c = new Vector2d();
            c.a = a.a * b.a;
            c.b = a.b * b.b;
            return (c);
        }

        /// <summary>
        /// Divide a <c>Vector3</c> through another
        /// </summary>
        /// <param name="a">The first <c>Vector3</c></param>
        /// <param name="b">The <c>Vector3</c> to divide thourght</param>
        /// <returns>Returns the division of a and b</returns>
        public static Vector2d operator /(Vector2d a, Vector2d b)
        {
            Vector2d c = new Vector2d();
            c.a = a.a / b.a;
            c.b = a.b / b.b;
            return (c);
        }
    }
}