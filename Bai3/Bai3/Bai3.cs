using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
	internal class Bai3
	{
		static void Main()
		{
			Console.WriteLine("Bài 3: " + KiemTraSoHoanThien(28));
		}
		static bool KiemTraSoHoanThien(int n)
		{
			int sum_104 = 0;
			for (int i = 1; i < n; i++)
				if (n % i == 0) sum_104 += i;
			return sum_104 == n;
		}
	}
}
