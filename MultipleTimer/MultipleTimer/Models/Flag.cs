using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTimer.Models
{

	public struct Flag
	{
		private bool done;

		public bool pure()
		{
			if (done)
			{
				return false;
			}
			else
			{
				done = true;
				return true;
			}
		}
	}

}
