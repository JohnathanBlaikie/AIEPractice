using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    class Program
    {
        public class v2
        {
            public float x, y;
            public v2(float X, float Y)
            {
                x = X;
                y = Y;
            }
            public static v2 operator +(v2 lhs, v2 rhs)
            {
                return new v2(lhs.x + rhs.x, lhs.y + rhs.y);
            }

            public static v2 operator -(v2 lhs, v2 rhs)
            {
                return new v2(lhs.x - rhs.x, lhs.y - rhs.y);
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
        public class v3
        {
            public float x, y, z;
            public v3(float X, float Y, float Z)
            {
                x = X;
                y = Y;
                z = Z;
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
        }
        public class Calculator
        {
            public double DTR(float deg)
            {
                return (deg / 180) * Math.PI;
            }
            public double RTD(float rad)
            {
                return (rad / Math.PI) * 180;
            }
        }
        public class Matrix3
        {
            public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
            public float[] m = new float[9];

            public Matrix3()
            {
                m[0] = 1; m[2] = 0; m[3] = 0;
                m[4] = 0; m[5] = 1; m[6] = 0;
                m[7] = 0; m[8] = 0; m[9] = 1;
            }
            public Matrix3(float[] tma)
            {
                //float mm1 = tma[0], mm2 = 0, mm3 = 0, mm4 = 0, mm5 = 0, mm6  = 0, mm7 = 0, mm8 = 0, mm9 = 0;
                ////m[1] = 1; m[2] = 0; m[3] = 0;
                ////m[4] = 0; m[5] = 1; m[6] = 0;
                ////m[7] = 0; m[8] = 0; m[9] = 1;
                //m[0] = mm1; m[1] = mm2; m[2] = mm3;
                //m[3] = mm4; m[4] = mm5; m[5] = mm6;
                //m[6] = mm7; m[7] = mm8; m[8] = mm9;
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

                //perfect transform
                /*
                 *   return new Matrix3(
                    lhs.m[0] * rhs.m[0] + lhs.m[3] * rhs.m[1] + lhs.m[6] * rhs.m[2],
                    lhs.m[0] * rhs.m[3] + lhs.m[3] * rhs.m[4] + lhs.m[6] * rhs.m[5],
                    lhs.m[0] * rhs.m[6] + lhs.m[3] * rhs.m[7] + lhs.m[6] * rhs.m[8],
                    lhs.m[1] * rhs.m[0] + lhs.m[4] * rhs.m[1] + lhs.m[7] * rhs.m[2],
                    lhs.m[1] * rhs.m[3] + lhs.m[4] * rhs.m[4] + lhs.m[7] * rhs.m[5],
                    lhs.m[1] * rhs.m[6] + lhs.m[4] * rhs.m[7] + lhs.m[7] * rhs.m[8],
                    lhs.m[2] * rhs.m[0] + lhs.m[5] * rhs.m[1] + lhs.m[8] * rhs.m[2],
                    lhs.m[2] * rhs.m[3] + lhs.m[5] * rhs.m[4] + lhs.m[8] * rhs.m[5],
                    lhs.m[2] * rhs.m[6] + lhs.m[5] * rhs.m[7] + lhs.m[8] * rhs.m[8]
                    );
                    */

                //lhs.m[0] * rhs.m[0] + lhs.m[3] * rhs.m[1] + lhs.m[6] * rhs.m[2],
                //lhs.m[1] * rhs.m[0] + lhs.m[4] * rhs.m[1] + lhs.m[7] * rhs.m[2],
                //lhs.m[2] * rhs.m[0] + lhs.m[5] * rhs.m[1] + lhs.m[8] * rhs.m[2],
                //lhs.m[0] * rhs.m[1] + lhs.m[3] * rhs.m[4] + lhs.m[6] * rhs.m[7],
                //lhs.m[1] * rhs.m[1] + lhs.m[4] * rhs.m[4] + lhs.m[7] * rhs.m[7],
                //lhs.m[2] * rhs.m[1] + lhs.m[5] * rhs.m[4] + lhs.m[8] * rhs.m[7],
                //lhs.m[0] * rhs.m[2] + lhs.m[3] * rhs.m[5] + lhs.m[6] * rhs.m[8],
                //lhs.m[1] * rhs.m[2] + lhs.m[4] * rhs.m[5] + lhs.m[7] * rhs.m[8],
                //lhs.m[2] * rhs.m[2] + lhs.m[5] * rhs.m[5] + lhs.m[8] * rhs.m[8]
                //lhs.m1* rhs.m1 + lhs.m4 * rhs.m4 + lhs.m7 * rhs.m7,
                //lhs.m2* rhs.m1 + lhs.m5 * rhs.m4 + lhs.m8 * rhs.m7,
                //lhs.m3* rhs.m1 + lhs.m6 * rhs.m4 + lhs.m9 * rhs.m7,
                //lhs.m1* rhs.m2 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m8,
                //lhs.m2* rhs.m2 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m8,
                //lhs.m3* rhs.m2 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m8,
                //lhs.m1* rhs.m3 + lhs.m4 * rhs.m6 + lhs.m7 * rhs.m9,
                //lhs.m2* rhs.m3 + lhs.m5 * rhs.m6 + lhs.m8 * rhs.m9,
                //lhs.m3* rhs.m3 + lhs.m6 * rhs.m6 + lhs.m9 * rhs.m9

                //lhs.m1 * rhs.m1 + lhs.m4 * rhs.m4 + lhs.m7 * rhs.m7,
                //lhs.m1 * rhs.m2 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m8,
                //lhs.m1 * rhs.m3 + lhs.m4 * rhs.m6 + lhs.m7 * rhs.m9,
                //lhs.m2 * rhs.m1 + lhs.m5 * rhs.m4 + lhs.m8 * rhs.m7,
                //lhs.m2 * rhs.m2 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m8,
                //lhs.m2 * rhs.m3 + lhs.m5 * rhs.m6 + lhs.m8 * rhs.m9,
                //lhs.m3 * rhs.m1 + lhs.m6 * rhs.m4 + lhs.m9 * rhs.m7,
                //lhs.m3 * rhs.m2 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m8,
                //lhs.m3 * rhs.m3 + lhs.m6 * rhs.m6 + lhs.m9 * rhs.m9
            }
        }
        static void Main(string[] args)
        {
            bool ok2Exit = false;
            while (!ok2Exit)
            {
                int temp;
                Console.WriteLine("Math Practice Program\nPlease Select a Subject:");
                Console.WriteLine("[1] Introduction");
                Console.WriteLine("[2] Trigonometry");
                Console.WriteLine("[3] Binary");
                Console.WriteLine("[4] Points and Vectors");
                Console.WriteLine("[5] Magnitude and Normalization");
                Console.WriteLine("[6] Dot and Cross Product");
                Console.WriteLine("[7] Matrices");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    int temp2;
                    Console.WriteLine("Please Select a Subject:");
                    Console.WriteLine("[1] Quadratic: f(x) = ax² + bx + c");
                    int.TryParse(Console.ReadLine(), out temp2);
                    if (temp2 == 1)
                    {
                        float a, b, c, x;
                        Console.Clear();
                        Console.WriteLine("Please enter a value for x:");
                        float.TryParse(Console.ReadLine(), out x);
                        Console.WriteLine("Please enter a value for a:");
                        float.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("Please enter a value for b:");
                        float.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("Please enter a value for c:");
                        float.TryParse(Console.ReadLine(), out c);
                        Console.Clear();
                        Console.WriteLine("f(x) = ax² + bx + c\n" +
                            $"f(x) = {a}({x})² + {b}({x}) + {c}");
                        Console.WriteLine($"f(x) = {a * (x * x) + b * x + c}");
                        Console.ReadKey();
                    }
                }
                else if (temp == 2)
                {
                    Calculator cal = new Calculator();
                    float temp2 = 0;
                    bool loop = true;
                    while (loop)
                    {
                        Console.WriteLine("Select an excercise:\n[1] Radian-Degree Conversion\n[2] Degree-Radian Conversion\n[0] Exit");
                        float.TryParse(Console.ReadLine(), out temp2);
                        if(temp2 == 1)
                        {
                            int temp3;
                            Console.WriteLine("Please enter a radian:");
                            int.TryParse(Console.ReadLine(), out temp3);
                            Console.WriteLine(cal.RTD(temp3));
                            
                        }
                        else if(temp2 == 2)
                        {
                            int temp3;
                            Console.WriteLine("Please enter a degree:");
                            int.TryParse(Console.ReadLine(), out temp3);
                            Console.WriteLine(cal.DTR(temp3));
                        }
                        else if( temp2 == 0)
                        {
                            loop = false;
                        }
                    }
                }
                else if (temp == 4)
                {

                }
                else if (temp == 5)
                {

                    bool loop = true;
                    while (loop)
                    {
                        float temp2 = 0;
                        Console.Clear();
                        Console.WriteLine("Please select an exercise:\n[1] Magnitude\n[2] Distance\n[0] Exit");
                        float.TryParse(Console.ReadLine(), out temp2);
                        if (temp2 == 1)
                        {
                            float x, y, z;
                            Console.WriteLine("Please enter a value for X:");
                            float.TryParse(Console.ReadLine(), out x);
                            Console.WriteLine("Please enter a value for Y:");
                            float.TryParse(Console.ReadLine(), out y);
                            Console.WriteLine("Please enter a value for Z:");
                            float.TryParse(Console.ReadLine(), out z);
                            v3 vec3 = new v3(x, y, z);
                            Console.WriteLine(vec3.Magnitude());
                            Console.ReadKey();
                        }
                        else if (temp2 == 2)
                        {

                            float x, y, z, x2, y2, z2;
                            Console.WriteLine("Please enter a value for X:");
                            float.TryParse(Console.ReadLine(), out x);
                            Console.WriteLine("Please enter a value for Y:");
                            float.TryParse(Console.ReadLine(), out y);
                            Console.WriteLine("Please enter a value for Z:");
                            float.TryParse(Console.ReadLine(), out z);
                            Console.WriteLine("Please enter a value for X:");
                            float.TryParse(Console.ReadLine(), out x2);
                            Console.WriteLine("Please enter a value for Y:");
                            float.TryParse(Console.ReadLine(), out y2);
                            Console.WriteLine("Please enter a value for Z:");
                            float.TryParse(Console.ReadLine(), out z2);
                            v3 vec3 = new v3(x, y, z);
                            v3 vec32 = new v3(x2, y2, z2);
                            Console.WriteLine(vec3.Distance(vec32));
                            Console.ReadKey();
                        }
                        else if (temp2 == 0)
                        {
                            loop = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid selection");
                        }
                    }
                }
                else if (temp == 6)
                {
                    bool loop = true;
                    while (loop)
                    {
                        float temp2 = 0;
                        Console.WriteLine("Please select an excercise:\n[1] Dot Product \n[2] Angle Between Vectors\n[0] Exit");
                        float.TryParse(Console.ReadLine(), out temp2);
                        if (temp2 == 1)
                        {
                            float x, y, z, x2, y2, z2;
                            Console.WriteLine("Enter a value for x:");
                            float.TryParse(Console.ReadLine(), out x);
                            Console.WriteLine("Enter a value for y:");
                            float.TryParse(Console.ReadLine(), out y);
                            Console.WriteLine("Enter a value for z:");
                            float.TryParse(Console.ReadLine(), out z);
                            Console.WriteLine("Enter a value for x:");
                            float.TryParse(Console.ReadLine(), out x2);
                            Console.WriteLine("Enter a value for y:");
                            float.TryParse(Console.ReadLine(), out y2);
                            Console.WriteLine("Enter a value for z:");
                            float.TryParse(Console.ReadLine(), out z2);
                            v3 vect3 = new v3(x,y,z);
                            v3 vect32 = new v3(x2, y2, z2);
                            Console.WriteLine(vect3.Dot(vect32)); 
                        }


                    }
                }
                else if (temp == 7)
                {
                   
                    bool loop = true;
                    while (loop)
                    {
                        int temp2;
                        Console.WriteLine("Please select an excercise:\n[1] Matrix Multiplication\n[2] Matrix-Vector Multiplication\n[0] Exit");
                        int.TryParse(Console.ReadLine(), out temp2);
                        if (temp2 == 1)
                        {
                            char tChar;
                            //float x11, y11, z11, x12, y12, z12, x13, y13, z13,
                            //    x21, y21, z21, x22, y22, z22, x23, y23, z23,
                            //    x31, y31, z31, x32, y32, z32, x33, y33, z33;
                            float[] mat1 = new float[9];
                            float[] mat2 = new float[9];
                            Console.WriteLine("Press [R] for a random matrix, [1] for an identity matrix, or [C] for a custom.");
                            tChar = char.ToLower(Console.ReadKey(true).KeyChar);
                            if (tChar == 'c')
                            {
                                for (int i = 0; i <= mat1.Length - 1; i++)
                                {
                                    Console.WriteLine($"Enter a value for #{i + 1}");
                                    float.TryParse(Console.ReadLine(), out mat1[i]);
                                }
                            }
                            else if(tChar == '1')
                            {
                                mat1[0] = 1;
                                mat1[4] = 1;
                                mat1[8] = 1;
                            }
                            else
                            {
                                Random r = new Random();
                                Console.WriteLine("Generating a random matrix...");
                                for (int i = 0; i <= mat1.Length - 1; i++)
                                {
                                    mat1[i] = r.Next(0, 1000);
                                }
                            }
                            Console.WriteLine("Press [R] for a random matrix, or [C] for a custom.");
                            tChar = char.ToLower(Console.ReadKey(true).KeyChar);
                            if (tChar == 'c')
                            {
                                for (int i = 0; i <= mat2.Length - 1; i++)
                                {
                                    Console.WriteLine($"Enter a value for #{i + 1}");
                                    float.TryParse(Console.ReadLine(), out mat2[i]);
                                }
                            }
                            else
                            {
                                Random r = new Random();
                                Console.WriteLine("Generating a random matrix...");
                                for (int i = 0; i <= mat2.Length - 1; i++)
                                {
                                    mat2[i] = r.Next(0, 1000);
                                }
                            }
                            int loopint = 0;
                            for (int i = 0; i <= 2; i++)
                            {
                                for (int j = 0; j <= 2; j++)
                                {
                                    Console.Write($"{mat1[loopint]}\t");

                                    loopint++;
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            int loopint2 = 0;
                            for (int i = 0; i <= 2; i++)
                            {
                                for (int j = 0; j <= 2; j++)
                                {
                                    Console.Write($"{mat2[loopint2]}\t");

                                    loopint2++;
                                }
                                Console.WriteLine();
                            }
                            Matrix3 matrix1 = new Matrix3(mat1);
                            Matrix3 matrix2 = new Matrix3(mat2);
                            Matrix3 result = matrix1 * matrix2;

                            Console.WriteLine(result.toString());
                            Console.ReadKey();
                            //Console.WriteLine("Enter a value for ");

                        }
                        else
                        {
                            loop = false;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection or section is unfinished.");
                }
            }
        }
    }
}
