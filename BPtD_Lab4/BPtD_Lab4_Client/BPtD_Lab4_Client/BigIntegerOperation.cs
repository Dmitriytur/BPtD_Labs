using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BPtD_Lab4_Client
{
	static class BigIntegerOperation
	{
		public static int ModPow(int value, int exponent, int modulus)
		{
			BigInteger bigPublic = new BigInteger(value);
			BigInteger bigPrivate = new BigInteger(exponent);
			BigInteger bigModule = new BigInteger(modulus);
			byte[] res = BigInteger.ModPow(bigPublic, bigPrivate, modulus).ToByteArray();
			byte[] extendedRes = new byte[4];
			Array.Copy(res, extendedRes, res.Length);
			return BitConverter.ToInt32(extendedRes, 0);
		}
	}
}
