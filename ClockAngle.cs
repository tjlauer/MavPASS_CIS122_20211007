// Thomas J. Lauer
// CIS 122 MavPASS Session
// October 07, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211007
{

	// This class contains the Student's solution to the Clock Angle problem.
	public class ClockAngle
	{
		public double CalcDegrees(double H, double M)
		{
			double ha = (H * 30) + (M * 0.5);
			double ma = M * 6;

			double result = Math.Abs(ha - ma);

			if (result > 180)
			{
				result = 360 - result;
			}

			return result;
		}

	}
}
