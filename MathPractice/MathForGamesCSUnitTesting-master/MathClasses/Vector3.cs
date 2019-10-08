using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class v3
    {
        public float x, y, z;
        public float[] vArray = new float[3];
        public v3(float X, float Y, float Z)
        {
            vArray[0] = X;
            vArray[1] = Y;
            vArray[2] = Z;

        }
        public v3(float[] tVA)
        {
            vArray = tVA;
        }

        public static v3 operator +(v3 lhs, v3 rhs)
        {
            return new v3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static v3 operator -(v3 lhs, v3 rhs)
        {
            return new v3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        public static v3 operator *(v3 lhs, float rhs)
        {
            return new v3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }
        public static v3 operator *(Matrix3 lhs, v3 rhs)
        {
            return new v3(
                (lhs.m[0] * rhs.vArray[0]) + (lhs.m[3] * rhs.vArray[1]) + (lhs.m[6] * rhs.vArray[2]),
                (lhs.m[1] * rhs.vArray[0]) + (lhs.m[4] * rhs.vArray[1]) + (lhs.m[7] * rhs.vArray[2]),
                (lhs.m[2] * rhs.vArray[0]) + (lhs.m[5] * rhs.vArray[1]) + (lhs.m[8] * rhs.vArray[2]));
        }
        public static v3 operator /(v3 lhs, float rhs)
        {
            return new v3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }
        public float Distance(v3 other)
        {
            float dX = x - other.x;
            float dY = y - other.y;
            float dZ = z - other.z;
            return (float)Math.Sqrt(dX * dX + dY * dY + dZ * dZ);
        }
        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
        }
        public v3 GetNormalized()
        {
            return (this / Magnitude());
        }
        public float Dot(v3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }
        public v3 Cross(v3 rhs)
        {
            return new v3(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x);
        }
        float AngleBetween(v3 other)
        {
            v3 a = GetNormalized();
            v3 b = other.GetNormalized();

            float d = a.x * b.x + a.y * b.y + a.z * b.z;
            return (float)Math.Acos(d);
        }
        public string toString()
        {
            return $"{vArray[0]} {vArray[1]} {vArray[2]}";
        }
    }
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

    }
}
