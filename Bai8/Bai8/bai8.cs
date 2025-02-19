using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
	internal class bai8
	{
		static void Main()
		{
			Console.Write("Nhập số thứ nhất: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nhập số thứ hai: ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nhập số thứ ba: ");
			double c = Convert.ToDouble(Console.ReadLine());

			double max = TimSoLonNhat(a, b, c);
			Console.WriteLine("Số lớn nhất là: " + max);
		}
		static double TimSoLonNhat(double a, double b, double c)
		{
			return Math.Max(a, Math.Max(b, c));
		}
	}
}
