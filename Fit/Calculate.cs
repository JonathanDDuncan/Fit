using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit
{
	public class Calculate
	{
		public static (int width1, int height1) GetSize(int width1, int height1, int width2, int height2)
		{
			
			width2 = width1;
			height2 = height1;

			return (width2, height2);
		}
	}
}
