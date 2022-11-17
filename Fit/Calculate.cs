using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit
{
	public class Calculate
	{
		public static (double width3, double height3) GetSize(double width1, double height1, double width2, double height2)
		{
			var widthAspect = width1 / width2;
			var heightAspect = height1 / height2;
			var aspect = widthAspect <= heightAspect ? widthAspect : heightAspect;

			var width3 = width2 * aspect;
			var height3 = height2 * aspect;

            return (width3, height3);
		}
	}
}
