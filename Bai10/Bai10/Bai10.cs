using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
	internal class Bai10
	{
		static void Main()
		{
			Console.WriteLine("Bài 117: " + TinhTong(2, 4));
		}
		static double TinhTong(double x, int n)
		{
			double sum_104 = 0, power = 1;
			for (int i = 1; i <= n; i++)
			{
				power *= x;
				sum_104 += power;
			}
			return sum_104;
		}
	}
}
