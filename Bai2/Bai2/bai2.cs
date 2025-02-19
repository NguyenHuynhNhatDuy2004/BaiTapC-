using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
	internal class bai2
	{
		static void Main()
		{
			Console.WriteLine("Bài 2: " + TinhTong(5));
		}
		static long TinhTong(int n)
		{
			long sum_104 = 0, factorial = 1;
			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
				sum_104 += factorial;
			}
			return sum_104;
		}
	}
}
