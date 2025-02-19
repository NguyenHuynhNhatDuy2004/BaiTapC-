using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
	internal class bai9
	{
		static void Main()
		{
			Console.Write("Bài 9: "); InSoLe();
		}
		static void InSoLe()
		{
			for (int i = 1; i < 100; i += 2)
				Console.Write(i + " ");
			Console.WriteLine();
		}
	}
}
