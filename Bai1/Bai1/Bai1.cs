using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
	internal class Bai1
	{
		static void Main()
		{
			Console.Write("Nhập n: ");
			int n_104 = int.Parse(Console.ReadLine());
			double sum = 0;
			for (int i = 1; i <= n_104; i++)
			{
				sum += 1.0 / (2 * i);
			}
			Console.WriteLine($"Tổng S({n_104}) = {sum:F4}");
		}
	}
}
