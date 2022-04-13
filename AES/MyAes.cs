using System;
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

        public string Encrypt(string str)
        {
            var encryptor = _provider.CreateEncryptor();

            var encryptedStrToByte = encryptor.TransformFinalBlock(Encoding.ASCII.GetBytes(str), 0, str.Length);
            var res = Convert.ToBase64String(encryptedStrToByte);
            return res;
        }

        public String Decrypt(string str)
        {
            var decryptor = _provider.CreateDecryptor();

            var encryptedStrToByte = Convert.FromBase64String(str);
            var decryptedBytes = decryptor.TransformFinalBlock(encryptedStrToByte, 0, encryptedStrToByte.Length);

            var res = Encoding.ASCII.GetString(decryptedBytes);
            return res;
        }
    }
}