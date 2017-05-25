using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESEncryption
{
	static class KeyGenerator
	{

		private const int amountOfRounds = 16;

		private static readonly int[] cKeyShuffleMatrix =
		{
			57, 49, 41, 33, 25, 17, 09, 01, 58, 50, 42, 34, 26, 18,
			10, 02, 59, 51, 43, 35, 27, 19, 11, 03, 60, 52, 44, 36

		};

		private static readonly int[] dKeyShuffleMatrix =
		{
			63, 55, 47, 39, 31, 23, 15, 07, 62, 54, 46, 38, 30, 22,
			14, 06, 61, 53, 45, 37, 29, 21, 13, 05, 28, 20, 12, 04
		};

		private static readonly int[] shiftAmount =
		{
			1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1
		};

		private static readonly int[] pBox =
		{
			14, 17, 11, 24, 01, 05, 03, 28,
			15, 06, 21, 10, 23, 19, 12, 04,
			26, 08, 16, 07, 27, 20, 13, 02,
			41, 52, 31, 37, 47, 55, 30, 40,
			51, 45, 33, 48, 44, 49, 39, 56,
			34, 53, 46, 42, 50, 36, 29, 32
		};


		internal static long[] GenerateRoundKeys(long mainKey)
		{
			long[] keys = new long[amountOfRounds];
			int cKey, dKey;
			ShuffleKey(mainKey, out cKey, out dKey);
			for (int i = 0; i < amountOfRounds; i++)
			{
				ShiftKey(ref cKey, shiftAmount[i]);
				ShiftKey(ref dKey, shiftAmount[i]);
				long key56 = (((long)cKey) << 28) | (long)dKey;
				long key48 = ShrinkKey(key56);
				keys[i] = key48; 
			}
			return keys; 
		}

		private static void ShuffleKey(long key, out int cKey, out int dKey)
		{
			cKey = 0;
			dKey = 0;
			int bit;
			for (int i = 0; i < 28; i++)
			{
				bit = (int)(key >> cKeyShuffleMatrix[i] - 1) & 1;
				cKey |= bit << i;

				bit = (int)(key >> dKeyShuffleMatrix[i] - 1) & 1;
				dKey |= bit << i;
			}
		}

		private static void ShiftKey(ref int key, int shift)
		{
			key <<= shift;
			int bits = key >> 28;
			if (shift == 1)
			{
				bits &= 1;
			}
			else
			{
				bits &= 3;
			}
			key |= bits;
			key &= 0x0FFFFFFF;
		}

		private static long ShrinkKey(long key56)
		{
			long key48 = 0;
			for (int i = 0; i < 48; i++)
			{
				long bit = (key56 >> pBox[i] - 1) & 1;
				key48 |= bit << i;
			}
			return key48;
		}
	}
}
