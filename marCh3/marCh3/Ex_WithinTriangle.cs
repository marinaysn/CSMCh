using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class Ex_WithinTriangle
    {

            public static int sign(int[] p1, int[] p2, int[] p3)
            {
                return (p1[0] - p3[0]) * (p2[1] - p3[1]) - (p2[0] - p3[0]) * (p1[1] - p3[1]);
            }
            public static bool WithinTriangle(int[] p1, int[] p2, int[] p3, int[] test)
            {
                {
                    int i1, i2, i3;
                    bool bNegative, bPositive;

                    i1 = sign(test, p1, p2);
                    i2 = sign(test, p2, p3);
                    i3 = sign(test, p3, p1);

                bNegative = (i1 < 0) || (i2 < 0) || (i3 < 0);
                bPositive = (i1 > 0) || (i2 > 0) || (i3 > 0);

                    return !(bNegative && bPositive);
                }
            }

        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 4, 5 })); // True
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 3, 2 })); // False
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 4, 2 })); // True
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 0, -4 })); // False
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { 1, 7 }, new int[] { 2, 4 }, new int[] { 9, 3 }, new int[] { 2, 6 })); // True
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { 1, 7 }, new int[] { 2, 4 }, new int[] { 9, 3 }, new int[] { 6, 5 })); // False
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { -2, 6 }, new int[] { 12, -3 }, new int[] { 1, 7 }, new int[] { 9, -1 })); // True
        //Console.WriteLine(E_WithinTriangle.WithinTriangle(new int[] { -2, 6 }, new int[] { 12, -3 }, new int[] { 1, 7 }, new int[] { 4, 2 })); // False


        public static bool WithinTriangle1(int[] p1, int[] p2, int[] p3, int[] test)
        {
            return (
                GetArea(p1, p2, test) +
                GetArea(p1, p3, test) +
                GetArea(p3, p2, test)) == GetArea(p1, p2, p3);
        }
        static double GetArea(int[] x, int[] y, int[] z)
        {
            return Math.Abs(
                (y[0] - x[0]) * (z[1] - x[1]) -
                (z[0] - x[0]) * (y[1] - x[1])) / 2;
        }


        public static bool WithinTriangle2(int[] p1, int[] p2, int[] p3, int[] test)
        {
            bool b0 = ((test[0] - p1[0]) * (p1[1] - p2[1])) + ((test[1] - p1[1]) * (p2[0] - p1[0])) > 0;
            bool b1 = ((test[0] - p2[0]) * (p2[1] - p3[1])) + ((test[1] - p2[1]) * (p3[0] - p2[0])) > 0;
            bool b2 = ((test[0] - p3[0]) * (p3[1] - p1[1])) + ((test[1] - p3[1]) * (p1[0] - p3[0])) > 0;

            return (b0 == b1 && b1 == b2);
        }


        public static bool WithinTriangle3(int[] p1, int[] p2, int[] p3, int[] test)
        {
            // early exit
            if (Math.Min(Math.Min(p1[0], p2[0]), p3[0]) > test[0] ||
                test[0] > Math.Max(Math.Max(p1[0], p2[0]), p3[0]))
                return false;
            // find intersections
            return (IsLineAbove(p1, p2, test) + IsLineAbove(p2, p3, test) + IsLineAbove(p3, p1, test)) % 2 == 1;
        }

        static int IsLineAbove(int[] p1, int[] p2, int[] test)
        {
            // early exit
            if (Math.Min(p1[0], p2[0]) > test[0] ||
                test[0] > Math.Max(p1[0], p2[0]))
                return 0;
            // get linear equation
            var a = (double)(p2[1] - p1[1]) / (p2[0] - p1[0]);
            var b = p1[1] - a * p1[0];
            // 1 if above, 0 if below
            return a * test[0] + b > test[1] ? 1 : 0;
        }

        public static bool WithinTriangle4(int[] p1, int[] p2, int[] p3, int[] p0)
        {
            int a0 = Math.Abs((p1[0] * (p2[1] - p3[1]) + p2[0] * (p3[1] - p1[1]) + p3[0] * (p1[1] - p2[1])) / 2);

            int a1 = Math.Abs((p0[0] * (p2[1] - p3[1]) + p2[0] * (p3[1] - p0[1]) + p3[0] * (p0[1] - p2[1])) / 2);

            int a2 = Math.Abs((p1[0] * (p0[1] - p3[1]) + p0[0] * (p3[1] - p1[1]) + p3[0] * (p1[1] - p0[1])) / 2);

            int a3 = Math.Abs((p1[0] * (p2[1] - p0[1]) + p2[0] * (p0[1] - p1[1]) + p0[0] * (p1[1] - p2[1])) / 2);

            return a1 + a2 + a3 == a0;
        }

    }
}




//Point Within Triangle
//Create a function that takes four integer arrays of 2 elements. The first three are (x, y) coordinates of three corners of a triangle. Return True if the fourth array — the (x, y) coordinates of a test point — lies within the triangle, False if it doesn't.

//Examples
//WithinTriangle((1, 4), (5, 6), (6, 1), (4, 5)) ➞ True

//WithinTriangle((1, 4), (5, 6), (6, 1), (3, 2)) ➞ False

//WithinTriangle((-6, 2), (-2, -2), (8, 4), (4, 2)) ➞ True
