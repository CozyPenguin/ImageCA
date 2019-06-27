namespace ImageCA.Vectors
{
    /// <summary>
    /// A vector containing 3 int values
    /// </summary>
    [System.Serializable]
    public struct Vector3i : IVector3
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
        public Vector3i(int a, int b, int c)
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
        public Vector3i(byte a, byte b, byte c)
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
        public Vector3i(short a, short b, short c)
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
        public static Vector3i Average(Vector3i a, Vector3i b)
        {
            Vector3i c = new Vector3i();
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
        public static Vector3i Average(Vector3i a, Vector3i b, Vector3i c)
        {
            Vector3i d = new Vector3i();
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
        public static Vector3i Average(Vector3i a, Vector3i b, Vector3i c, Vector3i d)
        {
            Vector3i e = new Vector3i();
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
        public Vector4f ToVector4Beginning(float d)
        {
            Vector4f vector = new Vector4f(a, b, c, d);
            return (vector);
        }

        /// <summary>
        /// Converts the <c>Vector3</c> to a <c>Vector4</c>
        /// <c>Vector3</c> is located at the end of <c>Vector4</c>
        /// </summary>
        /// <param name="a">the first parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector3</returns>

        public Vector4f ToVector4End(float a)
        {
            Vector4f vector = new Vector4f(a, this.a, b, c);
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
        public static Vector3i operator +(Vector3i a, Vector3i b)
        {
            Vector3i c = new Vector3i();
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
        public static Vector3i operator -(Vector3i a, Vector3i b)
        {
            Vector3i c = new Vector3i();
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
        public static Vector3i operator *(Vector3i a, Vector3i b)
        {
            Vector3i c = new Vector3i();
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
        public static Vector3i operator /(Vector3i a, Vector3i b)
        {
            Vector3i c = new Vector3i();
            c.a = a.a / b.a;
            c.b = a.b / b.b;
            c.c = a.c / b.c;
            return (c);
        }
    }
}