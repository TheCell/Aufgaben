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
            //Console.Read();

            StringList sl = new StringList();
            // Int-Property (setzt die Grösse der Liste)
            sl.Size = 5;
            Console.WriteLine("Size: " + sl.Size);
            
			// Zugriff auf Array über (Array-)Property
            sl.Data[1] = "Some value";
            sl.Data[3] = "Another value";

            foreach (string s in sl.Data)
            {
                Console.WriteLine("entry: " + s);
            }

            Console.WriteLine();
            
			// Zugriff auf Array über Indexer
            sl[4] = "Something else";
            sl[0] = sl[1] + ", " + sl[3];
            for (int i = 0; i < sl.Size; i++)
            {
                Console.WriteLine("entry[" + i + "]: " + sl[i]);
            }

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
