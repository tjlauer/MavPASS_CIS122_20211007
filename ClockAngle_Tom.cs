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

	// This class contains Tom's solution to the Clock Angle problem.
	public class ClockAngle_Tom
	{
		
		// Methods
		public double CalcDegrees(double H, double M)
		{
			double degH = ((H * 360) / 12) + ((M * 360) / (12 * 60));
			double degM = (M * 360) / 60;

			double angle = Math.Abs(degH - degM);

			if(angle > 180) { angle = 360 - angle; }

			Console.WriteLine("Input:  " + H + ":" + M);
			Console.WriteLine("Output: " + angle);
			Console.WriteLine(" ");

			return angle;
		}

	}
}
