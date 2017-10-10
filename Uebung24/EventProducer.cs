using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung24
{
	public class EventProducer
	{
		// Event deklarieren
		public event eventHandler myEventHandler;

		// Event "feuern"
		public void onMyEvent(string data)
		{
			if (myEventHandler != null)
			{
				myEventHandler(this, new MyEventArgs(data));
			}

			// Kurzform
			myEventHandler?.Invoke(this, new MyEventArgs(data));
		}
	}
}
