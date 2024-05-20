using System;

namespace MessageCrypterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Message Crypter App");

            var encryptor = new MessageEncryptor.Encryptor();
            var decryptor = new MessageDecryptor.Decryptor();

            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Encrypt a message");
                Console.WriteLine("2. Decrypt a message");
                Console.WriteLine("3. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the message to encrypt: ");
                        var messageToEncrypt = Console.ReadLine();
                        var encryptedMessage = encryptor.EncryptMessage(messageToEncrypt);
                        Console.WriteLine($"Encrypted message: {encryptedMessage}");
                        break;

                    case "2":
                        Console.Write("Enter the message to decrypt: ");
                        var messageToDecrypt = Console.ReadLine();
                        var decryptedMessage = decryptor.DecryptMessage(messageToDecrypt);
                        Console.WriteLine($"Decrypted message: {decryptedMessage}");
                        break;

                    case "3":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
            }
        }
    }
}
