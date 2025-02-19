using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
	internal class Bai4
	{
		static void Main()
		{
			Console.WriteLine("Bài 4: " + TinhSo(5));
		}
		static double TinhSo(int n)
		{
			double result_104 = 1;
			for (int i = n; i >= 1; i--)
				result_104 = 1 + 1 / result_104;
			return result_104;
		}
	}
}
