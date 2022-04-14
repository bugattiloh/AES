namespace AES
{
    class Program
    {
        private static void Main(string[] args)
        {
            var aes = new MyAes();
            // Console.Write("Введите текс,который хотели бы зашифровать:");
            // var plaintext = Console.ReadLine();
            // var encryptedText = aes.Encrypt(plaintext);
            // Console.WriteLine($"Зашифрофанный текст: {encryptedText}");
            // Console.WriteLine($"Текст,расшифрованный обратно: {aes.Decrypt(encryptedText)}");
            aes.Encrypt();
            aes.Decrypt();
        }
    }
}