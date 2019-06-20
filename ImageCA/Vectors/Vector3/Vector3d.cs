namespace ImageCA.Vectors
{
    /// <summary>
    /// A vector containing 3 int values
    /// </summary>
    [System.Serializable]
    public struct Vector3d : IVector3
    {
        /// <summary>
        /// the first value
        /// </summary>
        public int a { get; set; }
        /// <summary>
        /// the second value
        /// </summary>
        public int b { get; set; }
        /// <summary>
        /// the third value
        /// </summary>
        public int c { get; set; }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        public Vector3d(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        public Vector3d(byte a, byte b, byte c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Instantiates a new Vector3 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <param name="c">the third value</param>
        public Vector3d(short a, short b, short c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector3</param>
        /// <param name="b">The second Vector3</param>
        /// <returns>Returns the arithmetic mean of the vectors</returns>
        public static Vector3d Average(Vector3d a, Vector3d b)
        {
            Vector3d c = new Vector3d();
            c.a = a.a + b.a / 2;
            c.b = a.b + b.b / 2;
            c.c = a.c + b.c / 2;
            return (c);
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector3</param>
        /// <param name="b">The second Vector3</param>
        /// <param name="c">The third Vector3</param>
        /// <returns>returns the arithmetic mean of the vectors</returns>
        public static Vector3d Average(Vector3d a, Vector3d b, Vector3d c)
        {
            Vector3d d = new Vector3d();
            d.a = a.a + b.a + c.a / 3;
            d.b = a.b + b.b + c.b / 3;
            d.c = a.c + b.c + c.c / 3;
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
        public static Vector3d Average(Vector3d a, Vector3d b, Vector3d c, Vector3d d)
        {
            Vector3d e = new Vector3d();
            e.a = a.a + b.a + c.a + d.a / 4;
            e.b = a.b + b.b + c.b + d.b / 4;
            e.c = a.c + b.c + c.c + d.c / 4;
            return (e);
        }

        /// <summary>
        /// Converts the <c>Vector3</c> to a <c>Vector4</c>
        /// <c>Vector3</c> is located at the beginning of <c>Vector4</c>
        /// </summary>
        /// <param name="d">the fourth parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector3</returns>
        public Vector4 ToVector4Beginning(float d)
        {
            Vector4 vector = new Vector4(a, b, c, d);
            return (vector);
        }

        /// <summary>
        /// Converts the <c>Vector3</c> to a <c>Vector4</c>
        /// <c>Vector3</c> is located at the end of <c>Vector4</c>
        /// </summary>
        /// <param name="a">the first parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector3</returns>

        public Vector4 ToVector4End(float a)
        {
            Vector4 vector = new Vector4(a, this.a, b, c);
            return (vector);
        }

        /// <summary>
        /// Converts the vector to a string
        /// </summary>
        /// <returns>Returns a string of a Vector</returns>
        public override string ToString()
        {
            string output = a + ", " + b + ", " + c;
            return (output);
        }

        /// <summary>
        /// add two <c>Vector3</c> together
        /// </summary>
        /// <param name="a">the first <c>Vector3</c> to add</param>
        /// <param name="b">the second <c>Vector3</c> to add</param>
        /// <returns>Returns the sum of a and b</returns>
        public static Vector3d operator +(Vector3d a, Vector3d b)
        {
            Vector3d c = new Vector3d();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            c.c = a.c + b.c;
            return (c);
        }

        /// <summary>
        /// subtract a <c>Vector3</c> from another
        /// </summary>
        /// <param name="a">The <c>Vector3</c> to substract from</param>
        /// <param name="b">The <c>Vector3</c> to substract</param>
        /// <returns>Returns the substraction of a and b</returns>
        public static Vector3d operator -(Vector3d a, Vector3d b)
        {
            Vector3d c = new Vector3d();
            c.a = a.a - b.a;
            c.b = a.b - b.b;
            c.c = a.c - b.c;
            return (c);
        }

        /// <summary>
        /// Multiply two <c>Vector3</c>
        /// </summary>
        /// <param name="a">The first <c>Vector3</c> to multiply</param>
        /// <param name="b">The second <c>Vector3</c> to multiply</param>
        /// <returns>Returns the product of a and b</returns>
        public static Vector3d operator *(Vector3d a, Vector3d b)
        {
            Vector3d c = new Vector3d();
            c.a = a.a * b.a;
            c.b = a.b * b.b;
            c.c = a.c * b.c;
            return (c);
        }

        /// <summary>
        /// Divide a <c>Vector3</c> through another
        /// </summary>
        /// <param name="a">The first <c>Vector3</c></param>
        /// <param name="b">The <c>Vector3</c> to divide thourght</param>
        /// <returns>Returns the division of a and b</returns>
        public static Vector3d operator /(Vector3d a, Vector3d b)
        {
            Vector3d c = new Vector3d();
            c.a = a.a / b.a;
            c.b = a.b / b.b;
            c.c = a.c / b.c;
            return (c);
        }
    }
}