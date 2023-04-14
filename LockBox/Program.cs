using System;
using System.IO;
using System.Security.Cryptography;
using LockBox.Components;

namespace LockBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3 || args.Length > 4)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("    LockBox.exe --Encrypt InputFilePath OutputFile EncryptionKey");
                Console.WriteLine("    LockBox.exe --Decrypt InputFilePath OutputFile EncryptionKey");
                return;
            }

            string cryptionType = args[0];
            string inputFilePath = args[1];
            string outputFile = args[2];
            string encryptionKey = args[3];

            switch (cryptionType)
            {
                case "--Encrypt":
                    {
                        AesCrypto.FileEncrypt(inputFilePath, outputFile, encryptionKey);
                        Console.WriteLine($"Encoded a file {inputFilePath}\nAES(EncryptionKey) :: {encryptionKey}");
                        break;
                    }
                case "--Decrypt":
                    {
                        AesCrypto.FileDecrypt(inputFilePath, outputFile, encryptionKey);
                        Console.WriteLine($"Decoded a file {inputFilePath}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid command line option.");
                        break;
                    }
            }
        }
    }
}