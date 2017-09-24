﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1
{
    class Test
    {
        public Test()
        {
        }

        public void test1()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            method1(out a, out b, out c, ref d, ref e);
            Console.WriteLine(
                "a={0} b={1} c={2} d={3} e={4}",
                a,
                b,
                c,
                d,
                e);
        }

        public void method1(
            out int a,
            out int b,
            out int c,
            ref int d,
            ref int e)
        {
            //a = a + 1;
            a = 1;
            b = 2;
            c = 2 * d;
            d = c + e;
        }

        public void test2()
        {
            C a = new C();
            C b = new C();
            b.X = 2;
            C c = new C();
            c.X = 3;
            C d = new C();
            C e = c;

            method2(out a, ref b, c, d, e);
            Console.WriteLine(
                "a={0} b={1} c={2} d={3} e={4}",
                a.X,
                b.X,
                c.X,
                d.X,
                e.X);
        }

        public void method2(
            out C a,
            ref C b,
            C c,
            C d,
            C e)
        {
            b = new C();
            a = b;
            c = b;
            d = new C();
            d.X = 7;
            e.X = 9;
        }
        public class C
        {
            public int X;
        }
    }
}
