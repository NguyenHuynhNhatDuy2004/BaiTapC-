using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
	internal class Basi7
	{
		static void Main()
		{
			Console.WriteLine("Bài 7: " + TinhS(2, 4));
		}
		static double TinhS(double x, int n)
		{
			double sum_104 = 0, sumDenominator = 0, powX = 1;
			for (int i = 1; i <= n; i++)
			{
				sumDenominator += i;
				powX *= -x;
				sum_104 += powX / sumDenominator;
			}
			return sum_104;
		}
	}
}
