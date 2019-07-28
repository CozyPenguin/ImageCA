namespace ImageCA.Vectors
{
    /// <summary>
    /// A vector containing 2 float values
    /// </summary>
    [System.Serializable]
    public struct Vector2i : IVector2
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
        /// Instantiates a new Vector2 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2i(int a, int b)
        {
            this.a = a;
            this.b = b;

        }

        /// <summary>
        /// Instantiates a new Vector2 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2i(byte a, byte b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Instantiates a new Vector2 with the given values
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        public Vector2i(short a, short b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector2</param>
        /// <param name="b">The second Vector2</param>
        /// <returns>Returns the arithmetic mean of the vectors</returns>
        public static Vector2i Average(Vector2i a, Vector2i b)
        {
            Vector2i c = new Vector2i();
            c.a = a.a + b.a / 2;
            c.b = a.b + b.b / 2;
            return (c);
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector2</param>
        /// <param name="b">The second Vector2</param>
        /// <param name="c">The third Vector2</param>
        /// <returns>returns the arithmetic mean of the vectors</returns>
        public static Vector2i Average(Vector2i a, Vector2i b, Vector2i c)
        {
            Vector2i d = new Vector2i();
            d.a = a.a + b.a + c.a / 3;
            d.b = a.b + b.b + c.b / 3;
            return (d);
        }

        /// <summary>
        /// Returns the arithmetic mean of the vectors
        /// </summary>
        /// <param name="a">The first Vector2</param>
        /// <param name="b">The second Vector2</param>
        /// <param name="c">The third Vector2</param>
        /// <param name="d">The fourth Vector2</param>
        /// <returns>returns the arithmetic mean of the vectors</returns>
        public static Vector2i Average(Vector2i a, Vector2i b, Vector2i c, Vector2i d)
        {
            Vector2i e = new Vector2i();
            e.a = a.a + b.a + c.a + d.a / 4;
            e.b = a.b + b.b + c.b + d.b / 4;
            return (e);
        }

        /// <summary>
        /// Converts the <c>Vector2</c> to a <c>Vector4</c>
        /// <c>Vector2</c> is located at the beginning of <c>Vector4</c>
        /// </summary>
        /// <param name="c">the fourth parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector2</returns>
        public Vector3f ToVector4Beginning(int c)
        {
            Vector3f vector = new Vector3f(a, b, c);
            return (vector);
        }

        /// <summary>
        /// Converts the <c>Vector2</c> to a <c>Vector4</c>
        /// <c>Vector2</c> is located at the end of <c>Vector4</c>
        /// </summary>
        /// <param name="a">the first parameter of the <c>Vector4</c></param>
        /// <returns>the Vector4 of the Vector2</returns>

        public Vector3f ToVector4End(int a)
        {
            Vector3f vector = new Vector3f(a, this.a, b);
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
        /// add two <c>Vector2</c> together
        /// </summary>
        /// <param name="a">the first <c>Vector2</c> to add</param>
        /// <param name="b">the second <c>Vector2</c> to add</param>
        /// <returns>Returns the sum of a and b</returns>
        public static Vector2i operator +(Vector2i a, Vector2i b)
        {
            Vector2i c = new Vector2i();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            return (c);
        }

        /// <summary>
        /// subtract a <c>Vector2</c> from another
        /// </summary>
        /// <param name="a">The <c>Vector2</c> to substract from</param>
        /// <param name="b">The <c>Vector2</c> to substract</param>
        /// <returns>Returns the substraction of a and b</returns>
        public static Vector2i operator -(Vector2i a, Vector2i b)
        {
            Vector2i c = new Vector2i();
            c.a = a.a - b.a;
            c.b = a.b - b.b;
            return (c);
        }

        /// <summary>
        /// Multiply two <c>Vector2</c>
        /// </summary>
        /// <param name="a">The first <c>Vector2</c> to multiply</param>
        /// <param name="b">The second <c>Vector2</c> to multiply</param>
        /// <returns>Returns the product of a and b</returns>
        public static Vector2i operator *(Vector2i a, Vector2i b)
        {
            Vector2i c = new Vector2i();
            c.a = a.a * b.a;
            c.b = a.b * b.b;
            return (c);
        }

        /// <summary>
        /// Divide a <c>Vector2</c> through another
        /// </summary>
        /// <param name="a">The first <c>Vector2</c></param>
        /// <param name="b">The <c>Vector2</c> to divide thourght</param>
        /// <returns>Returns the division of a and b</returns>
        public static Vector2i operator /(Vector2i a, Vector2i b)
        {
            Vector2i c = new Vector2i();
            c.a = a.a / b.a;
            c.b = a.b / b.b;
            return (c);
        }
    }
}