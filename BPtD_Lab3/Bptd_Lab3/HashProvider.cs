using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bptd_Lab3
{
	static class HashProvider
	{
		private static RSACryptoServiceProvider prov = new RSACryptoServiceProvider(1024);

		public static int GetHash(string path)
		{
			byte[] file = File.ReadAllBytes(path);
			SHA1 sha = SHA1.Create();
			byte[] hash = sha.ComputeHash(file);
			return hash[0] >> 4;
		}

		public static void MakeSign(string filePath, string signPath)
		{
			byte[] file = File.ReadAllBytes(filePath);
			byte[] hash = BitConverter.GetBytes(GetHash(filePath));
			byte[] sign =  prov.Encrypt(hash, false);

			File.WriteAllBytes(signPath, sign);
		}

		public static bool CheckSign(string filePath, string signPath)
		{
			int sourceHash = GetHash(filePath);

			byte[] sign = File.ReadAllBytes(signPath);
			byte[] hash = prov.Decrypt(sign, false);

			int realHash = BitConverter.ToInt32(hash, 0);

			return sourceHash == realHash;
		}
	}
}
