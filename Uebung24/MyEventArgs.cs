using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung24
{
	public class MyEventArgs : EventArgs
	{
		//public string eventData;
		public string eventData { get; private set; }

		public MyEventArgs(string eventData)
		{
			this.eventData = eventData;
		}
	}
}
