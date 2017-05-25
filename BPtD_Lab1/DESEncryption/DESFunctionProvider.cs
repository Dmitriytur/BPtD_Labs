using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESEncryption
{
	static class DESFunctionProvider
	{
		private static readonly int[] extensionBox =
		{
			32, 01, 02, 03, 04, 05,
			04, 05, 06, 07, 08, 09,
			08, 09, 10, 11, 12, 13,
			12, 13, 14, 15, 16, 17,
			16, 17, 18, 19, 20, 21,
			20, 21, 22, 23, 24, 25,
			24, 25, 26, 27, 28, 29,
			28, 29, 30, 31, 32, 01
		};

		private static readonly int[][][] sBoxes =
		{
			new int[][]
			{
				new int[] {14, 04, 13, 01, 02, 15, 11, 08, 03, 10, 06, 12, 05, 09, 00, 07 },
				new int[] {00, 15, 07, 04, 14, 02, 13, 01, 10, 06, 12, 11, 09, 05, 03, 08 },
				new int[] {04, 01, 14, 08, 13, 06, 02, 11, 15, 12, 09, 07, 03, 10, 05, 00 },
				new int[] {15, 12, 08, 02, 04, 09, 01, 07, 05, 11, 03, 14, 10, 00, 06, 13 }
			},
			new int[][]
			{
				new int[] { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 },
				new int[] { 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 },
				new int[] { 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 },
				new int[] { 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 }
			},
			new int[][]
			{
				new int[] { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 },
				new int[] { 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 },
				new int[] { 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 },
				new int[] { 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12, }
			},
			new int[][]
			{
				new int[] { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 },
				new int[] { 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 },
				new int[] { 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 },
				new int[] { 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 }
			},
			new int[][]
			{
				new int[] { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 },
				new int[] { 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 },
				new int[] { 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 },
				new int[] { 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 }
			},
			new int[][]
			{
				new int[] { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 },
				new int[] { 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 },
				new int[] { 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 },
				new int[] { 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 }
			},
			new int[][]
			{
				new int[] { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 },
				new int[] { 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 },
				new int[] { 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 },
				new int[] { 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 }
			},
			new int[][]
			{
				new int[] { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 },
				new int[] { 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 },
				new int[] { 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 },
				new int[] { 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 }
			}
		};

		private static readonly int[] directPBox =
		{
			16, 07, 20, 21, 29, 12, 28, 17,
			01, 15, 23, 26, 05, 18, 31, 10,
			02, 08, 24, 14, 32, 27, 03, 09,
			19, 13, 30, 06, 22, 11, 04, 25
		};


		internal static int CountFunction(int right, long roundKey)
		{
			long block48 = ExtendBlock(right);
			long encryptedBlock48 = block48 ^ (roundKey & 0x0000FFFFFFFFFFFF);
			int block32 = doSBoxes(encryptedBlock48);
			int shuffledBlock32 = ShuffleBlock32(block32);

			return shuffledBlock32;
		}

		private static long ExtendBlock(int block32)
		{
			long block48 = 0;
			for (int i = 0; i < 48; i++)
			{
				long bit = (block32 >> extensionBox[i] - 1) & 1;
				block48 |= bit << i;
			}
			return block48;
		}

		private static int doSBoxes(long block48)
		{
			int block32 = 0;
			for (int i = 0; i < 8; i++)
			{
				int block6 = (int)(block48 >> 6 * (7 - i));
				block6 &= 0x3F;
				int row = ((block6 >> 4) & 2) | (block6 & 1);
				int colum = (block6 >> 1) & 0xF;
				int block4 = sBoxes[i][row][colum];
				block32 |= block4 << (7 - i) * 4;
			}
			return block32;
		}

		private static int ShuffleBlock32(int block32)
		{
			int resultBlock = 0;
			for (int i = 0; i < 32; i++)
			{
				int bit = (block32 >> directPBox[i] - 1) & 1;
				resultBlock |= bit << i;
			}
			return resultBlock;
		}
	}

}