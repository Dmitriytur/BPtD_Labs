using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPtD_Lab4_Server
{
	static class ValueGenerator
	{

		public static int IntModPower(int A, int B, int n)
		{
			int[] x = new int[n];
			x[0] = A % n;

			for (int i = 1; i < B; i++)
				x[i] = x[i - 1] * A % n;

			return x[B - 1];
		}

		public static int CalculateSqrt(int P)
		{
			int g = 0;
			int d = (P - 1) / 2;

			int i = 2;

			while (IntModPower(i, d, P) != P - 1)
				i++;
			g = Convert.ToInt32(Math.Pow(i, d) % P);

			return g;
		}

		public static bool IsSimple(int n)
		{
			bool res = true;
			for (int i = 2; i * i <= n; i++)
			{
				if (n % i == 0)
				{
					res = false;
				}
			}
			return res;
		}

		public static int Simple(int n)
		{
			int x = 0;
			int i;
			for (i = 2; x < n; i++)
			{
				if (IsSimple(i))
				{
					x++;
				}
			}
			return i - 1;
		}

		public static void GenerateModuleAndPublic(out int module, out int publicValue)
		{
			Random r = new Random();
			int n = r.Next(80, 100);
			module = Simple(n);
			publicValue = CalculateSqrt(module);
			if (module - publicValue == 1)
			{
				GenerateModuleAndPublic(out module, out publicValue);
			}
		}
	}
}
