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
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(new ClockAngle().CalcDegrees( 5, 30)); // Should be 15
			Console.WriteLine(new ClockAngle().CalcDegrees( 9, 00)); // Should be 90
			Console.WriteLine(new ClockAngle().CalcDegrees(12, 00)); // Should be 0

			Console.ReadLine();
		}
	}
}
