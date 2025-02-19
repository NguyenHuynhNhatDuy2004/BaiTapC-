using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
	internal class Bai5
	{
		static void Main()
		{
			Console.WriteLine("Bài 5: " + TimChuSoLonNhat(98765));
		}
		static int TimChuSoLonNhat(int n)
		{
			int max_104 = 0;
			while (n > 0)
			{
				max_104 = Math.Max(max_104, n % 10);
				n /= 10;
			}
			return max_104;
		}
	}
}
