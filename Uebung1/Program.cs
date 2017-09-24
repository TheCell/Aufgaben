using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1
{
    class Program
    {
        #region methods
        /// <summary>
        /// Displays a Message on the Screen
        /// </summary>
        /// <param name="msg">the Message to display</param>
        /// <param name="upperCase">true => Display in uppercase</param>
        private static void printMessage(
            string msg, 
            bool upperCase)
        {
            #region upperCase
            if (upperCase)
            {
                msg = msg.ToUpper();
            }
            #endregion
            Console.WriteLine(msg);
        }
        #endregion

        static void Main(string[] args)
        {
            printMessage("Hello World", false);
            printMessage("Hello World", true);
            

            ClassA A = new ClassA("A");
            ClassB B0 = new ClassB();
            ClassB B1 = new ClassB("B1");
            ClassB B2 = new ClassB("B2", 2);

            Console.WriteLine("");

            ClassA AA = new ClassA("AA");
            ClassA AB = new ClassB("AB");

            Console.Read();
        }
    }
}
