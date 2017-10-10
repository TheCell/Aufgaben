using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung24
{
	class EventConsumer
	{
		public eventHandler personalEventhandler;

		public EventConsumer(EventProducer producer)
		{
			producer.myEventHandler += personalEventhandler;
		}
	}
}
