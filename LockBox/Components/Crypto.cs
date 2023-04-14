using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LockBox.Components
{
    public static class AesCrypto
    {
        public static void FileEncrypt(string inputFile, string outputFile, string password)
        {
            byte[] salt = GenerateSalt();

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt, 1000);
                aes.Key = keyGenerator.GetBytes(32);
                aes.IV = keyGenerator.GetBytes(16);

                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    outputFileStream.Write(salt, 0, salt.Length);

                    inputFileStream.CopyTo(cryptoStream);
                }
            }
        }

        public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
            {
                byte[] salt = new byte[32];
                inputFileStream.Read(salt, 0, salt.Length);

                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;

                    Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt, 1000);
                    aes.Key = keyGenerator.GetBytes(32);
                    aes.IV = keyGenerator.GetBytes(16);

                    using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(outputFileStream);
                    }
                }
            }
        }

        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }
    }
}