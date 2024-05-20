namespace MessageDecryptor
{
    public class Decryptor
    {
        private const int Shift = 3; // Number of positions to shift

        // Decrypts a message encrypted with a simple Caesar cipher
        public string DecryptMessage(string encryptedMessage)
        {
            char[] decryptedMessage = new char[encryptedMessage.Length];

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char encryptedChar = encryptedMessage[i];
                char decryptedChar = (char)(encryptedChar - Shift);
                decryptedMessage[i] = decryptedChar;
            }

            return new string(decryptedMessage);
        }
    }
}
