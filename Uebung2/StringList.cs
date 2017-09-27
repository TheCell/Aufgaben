using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2
{
    class StringList
    {
		protected string[] data;

		public StringList()
		{
			data = new string[0];
		}

		public int Size
		{
			get
			{
				return data.Length;
			}

			set
			{
				data = new string[value];
				for (int i = 0; i < data.Length; i++)
				{
					data[i] = "<empty>";
				}
			}
		}

		public string[] Data
		{
			get
			{
				return data;
			}
		}
		
        public string this [int index]
        {
            get
            {
                return data[index];
            }

            set
            {
                data[index] = value;
            }
        }
    }
}
