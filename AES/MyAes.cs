using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AES
{
    public class MyAes
    {
        private readonly AesCryptoServiceProvider _provider;

        public MyAes()
        {
            _provider = new AesCryptoServiceProvider {BlockSize = 128, KeySize = 256};
            _provider.GenerateKey();
            _provider.GenerateIV();
            _provider.Mode = CipherMode.CBC;
            _provider.Padding = PaddingMode.PKCS7;
        }

        public void Encrypt()
        {
            var encryptor = _provider.CreateEncryptor();

            var pngToBytes = File.ReadAllBytes("C:\\Users\\1255968\\Desktop\\AES\\AES\\source\\Jessei.png");
            var encryptedStrToByte = encryptor.TransformFinalBlock(pngToBytes, 0, pngToBytes.Length);

            File.WriteAllBytes("C:\\Users\\1255968\\Desktop\\AES\\AES\\Encrypted\\EncryptedJessei.png",
                encryptedStrToByte);
        }

        public void Decrypt()
        {
            var decryptor = _provider.CreateDecryptor();

            var pngToBytes = File.ReadAllBytes("C:\\Users\\1255968\\Desktop\\AES\\AES\\Encrypted\\EncryptedJessei.png");
            var decryptedBytes = decryptor.TransformFinalBlock(pngToBytes, 0, pngToBytes.Length);

            File.WriteAllBytes("C:\\Users\\1255968\\Desktop\\AES\\AES\\Decrypted\\DecryptedJessei.png", decryptedBytes);
        }
    }
}