namespace MessageEncryptor
{
    public class Encryptor
    {
        private const int Shift = 3; // Number of positions to shift

        // Encrypts a message using a simple Caesar cipher
        public string EncryptMessage(string message)
        {
            char[] encryptedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char originalChar = message[i];
                char encryptedChar = (char)(originalChar + Shift);
                encryptedMessage[i] = encryptedChar;
            }

            return new string(encryptedMessage);
        }
    }
}
