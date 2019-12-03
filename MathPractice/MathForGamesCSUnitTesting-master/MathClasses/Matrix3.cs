using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
       
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
       
        //public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        public float[] m = new float[9];

        public Matrix3()
        {
            m[0] = 1; m[1] = 0; m[2] = 0;
            m[3] = 0; m[4] = 1; m[5] = 0;
            m[6] = 0; m[7] = 0; m[8] = 1;
        }
       
        public void SetScaled(float x, float y, float z)
        {
            m[0] = x; m[1] = 0; m[2] = 0;
            m[3] = 0; m[4] = y; m[5] = 0;
            m[6] = 0; m[7] = 0; m[8] = z;
        }
        public void SetScaled(Vector3 v)
        {
            m[0] = v.x; m[1] = 0; m[2] = 0;
            m[3] = 0; m[4] = v.y; m[5] = 0;
            m[6] = 0; m[7] = 0; m[8] = v.z;
        }
        public void Set(Matrix3 _m)
        {

            m[0] = _m.m[0]; m[1] = _m.m[1]; m[2] = _m.m[2];
            m[3] = _m.m[3]; m[4] = _m.m[4]; m[5] = _m.m[5];
            m[6] = _m.m[6]; m[7] = _m.m[7]; m[8] = _m.m[8];

        }
        public void Set(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            m[0] = m1; m[1] = m2; m[2] = m3;
            m[3] = m4; m[4] = m5; m[5] = m6;
            m[6] = m7; m[7] = m6; m[8] = m9;
        }

        public void Scale(float x, float y, float z)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(x, y, z);
            Set(this * m);
        }
        void Scale(Vector3 v)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(v.x, v.y, v.z);
            Set(this * m);
        }
        public Matrix3(float[] tma)
        {
            m = tma;
        }
        public Matrix3(float mm1, float mm2, float mm3, float mm4, float mm5, float mm6, float mm7, float mm8, float mm9)
        {
            m[0] = mm1; m[1] = mm2; m[2] = mm3;
            m[3] = mm4; m[4] = mm5; m[5] = mm6;
            m[6] = mm7; m[7] = mm8; m[8] = mm9;
            //mm1 = m1; mm2 = m2; mm3 = m3;
            //mm4 = m4; mm5 = m5; mm6 = m6;
            //mm7 = m7; mm8 = m8; mm9 = m9;
        }
        public string toString()
        {
            return $"{m[0]} {m[1]} {m[2]}\n{m[3]} {m[4]} {m[5]}\n{m[6]} {m[7]} {m[8]}";
        }
        public void SetRotateX(double radians)
        {
            Set(1, 0, 0, 
                0, (float)Math.Cos(radians), (float)Math.Sin(radians), 0, 
                (float)-Math.Sin(radians), (float)Math.Cos(radians));
        }
        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, -(float)Math.Sin(radians),
                0, 1, 0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians));
        }
        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0,
                (float)-Math.Sin(radians), (float)Math.Cos(radians), 0,
                0,0,1);
        }

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(
                lhs.m[0] * rhs.m[0] + lhs.m[3] * rhs.m[1] + lhs.m[6] * rhs.m[2],

                lhs.m[1] * rhs.m[0] + lhs.m[4] * rhs.m[1] + lhs.m[7] * rhs.m[2],

                lhs.m[2] * rhs.m[0] + lhs.m[5] * rhs.m[1] + lhs.m[8] * rhs.m[2],

                lhs.m[0] * rhs.m[3] + lhs.m[3] * rhs.m[4] + lhs.m[6] * rhs.m[5],

                lhs.m[1] * rhs.m[3] + lhs.m[4] * rhs.m[4] + lhs.m[7] * rhs.m[5],

                lhs.m[2] * rhs.m[3] + lhs.m[5] * rhs.m[4] + lhs.m[8] * rhs.m[5],

                lhs.m[0] * rhs.m[6] + lhs.m[3] * rhs.m[7] + lhs.m[6] * rhs.m[8],

                lhs.m[1] * rhs.m[6] + lhs.m[4] * rhs.m[7] + lhs.m[7] * rhs.m[8],

                lhs.m[2] * rhs.m[6] + lhs.m[5] * rhs.m[7] + lhs.m[8] * rhs.m[8]
                );
        }
    }
}