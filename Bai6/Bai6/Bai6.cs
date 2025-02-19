using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
	internal class Bai6
	{
		static void Main()
		{
			Console.WriteLine("Bài 6: " + TimBCNN(12, 18));
		}
		static int TimBCNN(int a, int b)
		{
			int gcd_104 = TimUCLN(a, b);
			return (a * b) / gcd_104;
		}
		static int TimUCLN(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}
}
