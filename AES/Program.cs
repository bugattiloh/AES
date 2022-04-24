namespace AES
{
    class Program
    {
        private static void Main(string[] args)
        {
            var aes = new MyAes();
            aes.Encrypt();
            aes.Decrypt();
        }
    }
}