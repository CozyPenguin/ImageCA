using System;
using System.Collections.Generic;
using System.Text;

namespace ImageCA.Vectors
{
    interface IVector3 : IVector
    {
        Vector4 ToVector4Beginning(float d);
        Vector4 ToVector4End(float a);
        string ToString();
    }
}
