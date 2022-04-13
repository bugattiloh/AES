using System;
using System.Security.Cryptography;
using System.Text;

namespace AES
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var aes = new MyAes();
            var plaintext = Console.ReadLine();
            var encryptedText = aes.Encrypt(plaintext);
            Console.WriteLine(encryptedText);
            Console.WriteLine(aes.Decrypt(encryptedText));
        }
    }
}