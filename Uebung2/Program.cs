using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2
{
    class Program
    {
        static void Main(string[] args)
        {
            test(1, 2);
            test(1, 2, 3);
            Console.Read();
        }

        // test method signature
        public static void test(params int[]a)
        {
            Console.WriteLine("params");
        }

        public static void test(int a, int b)
        {
            Console.WriteLine("int int");
        }
    }
}
