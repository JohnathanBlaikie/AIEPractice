using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
       

    }
    public class v4
    {
        public float[] v = new float[4];

        public v4(float[] vec4)
        {
            v = vec4;
        }
        public v4(float x, float y, float z, float w)
        {
            v[0] = x;
            v[1] = y;
            v[2] = z;
            v[3] = w;
        }
        public v4()
        {
            v[0] = 0;
            v[1] = 0;
            v[2] = 0;
            v[3] = 0;
        }
        public static v4 operator +(v4 lhs, v4 rhs)
        {
            return new v4
                (
                lhs.v[0] + rhs.v[0],
                lhs.v[1] + rhs.v[1],
                lhs.v[2] + rhs.v[2],
                lhs.v[3] + rhs.v[3]
                );
        }
        public static v4 operator -(v4 lhs, v4 rhs)
        {
            return new v4
                (
                lhs.v[0] - rhs.v[0],
                lhs.v[1] - rhs.v[1],
                lhs.v[2] - rhs.v[2],
                lhs.v[3] - rhs.v[3]
                );
        }
        public static v4 operator *(v4 lhs, float rhs)
        {
            return new v4
                (
                lhs.v[0] * rhs,
                lhs.v[1] * rhs,
                lhs.v[2] * rhs,
                lhs.v[3] * rhs
                );
        }
        public static v4 operator *(Matrix4 lhs, v4 rhs)
        {
            return new v4(
            (rhs.v[0] * lhs.m[0]) + (rhs.v[1] * lhs.m[4]) + (rhs.v[2] * lhs.m[8]) + (rhs.v[3] * lhs.m[12]),
            (rhs.v[0] * lhs.m[1]) + (rhs.v[1] * lhs.m[5]) + (rhs.v[2] * lhs.m[9]) + (rhs.v[3] * lhs.m[13]),
            (rhs.v[0] * lhs.m[2]) + (rhs.v[1] * lhs.m[6]) + (rhs.v[2] * lhs.m[10]) + (rhs.v[3] * lhs.m[14]),
            (rhs.v[0] * lhs.m[3]) + (rhs.v[1] * lhs.m[7]) + (rhs.v[2] * lhs.m[11]) + (rhs.v[3] * lhs.m[15])
            );
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt((double)(v[0] * v[0] + v[1] * v[1] + v[2] * v[2] + v[3] * v[3]));
        }
        public void Normalize()
        {
            float m = Magnitude();
            v[0] /= m;
            v[1] /= m;
            v[2] /= m;
            v[3] /= m;

        }
        public float Dot(v4 rhs)
        {
            return v[0] * rhs.v[0] + v[1] * rhs.v[1] + v[2] * rhs.v[2] + v[3] * rhs.v[3];
        }
        public v4 Cross(v4 rhs)
        {
            return new v4(
                v[1] * rhs.v[2] - v[2] * rhs.v[1],
                v[2] * rhs.v[0] - v[0] * rhs.v[2],
                v[0] * rhs.v[1] - v[1] * rhs.v[0],
                0);
        }
    }
}
