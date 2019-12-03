using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector2
    {
        public float x, y;
        public Vector2(float X, float Y)
        {
            x = X;
            y = Y;
        }
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }
        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            return new Vector2((float)(lhs.x * rhs), (float)(lhs.y * rhs));
        }
        public static Vector2 operator *(float rhs, Vector2 lhs)
        {
            return new Vector2((float)(lhs.x * rhs), (float)(lhs.y * rhs));
        }
        
        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            return new Vector2((float)(lhs.x / rhs), (float)(lhs.y / rhs));
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        public float MagnitudeSqr()
        {
            return (x * x + y * y);
        }
        public float Distance(Vector2 other)
        {
            float dX = x - other.x;
            float dY = y - other.y;
            return (float)Math.Sqrt(dX * dX + dY * dY);
        }
        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
        }
        public Vector2 GetNormalized()
        {
            return (this / Magnitude());
        }
        public float Dot(Vector2 rhs)
        {
            return x * rhs.x + y * rhs.y;
        }
       
        float AngleBetween(Vector2 other)
        {
            Vector2 a = GetNormalized();
            Vector2 b = other.GetNormalized();

            float d = a.x * b.x + a.y * b.y;
            return (float)Math.Acos(d);
        }
        public string toString()
        {
            return $"{x} {y}";
        }
        
        //public v2 GetPerpRH()
        //{
        //    return { -y, x};
        //}
        //public v2 GetPerpLH()
        //{
        //    return { y, -x};
        //}
    }
    public class Vector3
    {
        public float x, y, z;
        public float[] vArray = new float[3];
        public Vector3(float X, float Y, float Z)
        {
            vArray[0] = X;
            vArray[1] = Y;
            vArray[2] = Z;

        }
        public Vector3(float[] tVA)
        {
            vArray = tVA;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3((float)(lhs.x + rhs.x), (float)(lhs.y + rhs.y), (float)(lhs.z + rhs.z));
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3((float)(lhs.x - rhs.x), (float)(lhs.y - rhs.y), (float)(lhs.z - rhs.z));
        }
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3((float)(lhs.x * rhs), (float)(lhs.y * rhs), (float)(lhs.z * rhs));
        }
        public static Vector3 operator *(float rhs, Vector3 lhs)
        {
            return new Vector3((float)(lhs.x * rhs), (float)(lhs.y * rhs), (float)(lhs.z * rhs));
        }
        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3(
                (lhs.m[0] * rhs.vArray[0]) + (lhs.m[3] * rhs.vArray[1]) + (lhs.m[6] * rhs.vArray[2]),
                (lhs.m[1] * rhs.vArray[0]) + (lhs.m[4] * rhs.vArray[1]) + (lhs.m[7] * rhs.vArray[2]),
                (lhs.m[2] * rhs.vArray[0]) + (lhs.m[5] * rhs.vArray[1]) + (lhs.m[8] * rhs.vArray[2]));
        }
        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3((float)(lhs.x / rhs), (float)(lhs.y / rhs), (float)(lhs.z / rhs));
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(vArray[0] * vArray[0] + vArray[1] * vArray[1] + vArray[2] * vArray[2]);
        }
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }
        public float Distance(Vector3 other)
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
        public Vector3 GetNormalized()
        {
            return (this / Magnitude());
        }
        public float Dot(Vector3 rhs)
        {
            return vArray[0] * rhs.vArray[0] + vArray[1] * rhs.vArray[1] + vArray[2] * rhs.vArray[2];
        }
        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
            (float)(this.y * rhs.z - this.z * rhs.y),
            (float)(this.z * rhs.x - this.x * rhs.z),
            (float)(this.x * rhs.y - this.y * rhs.x));
        }
        float AngleBetween(Vector3 other)
        {
            Vector3 a = GetNormalized();
            Vector3 b = other.GetNormalized();

            float d = a.x * b.x + a.y * b.y + a.z * b.z;
            return (float)Math.Acos(d);
        }
        public string toString()
        {
            return $"{vArray[0]} {vArray[1]} {vArray[2]}";
        }
        //}
        //public class v3
        //{
        //    public float x, y, z;

        //    public v3()
        //    {
        //        x = 0;
        //        y = 0;
        //        z = 0;
        //    }

        //}
    }
}
