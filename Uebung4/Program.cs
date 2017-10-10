using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung4
{
	class Program
	{
		public delegate void myDelegate(string msg);
		private myDelegate del;

		static void Main(string[] args)
		{
			Program p = new Program();
			p.test();
		}

		public void printMessage(string msg)
		{
			Console.WriteLine("Delegate called: " + msg);
		}

		void test()
		{
			del = printMessage;
			del += printMessage;

			del("myDelegate");

			Delegate[] items = del.GetInvocationList();

			for (int j = 0; j < items.Length; j++)
			{
				((myDelegate)items[j]).Invoke("Hello");
			}

			int i = 0;
			foreach(myDelegate item in items)
			{
				item("Aufruf " + ++i);
				item.Invoke("Aufruf " + i); // Alternative
			}
		}
	}
}
