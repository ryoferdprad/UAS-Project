using NUnit.Framework;

namespace MessageDecryptor.Tests
{
    public class DecryptorTests
    {
        [Test]
        public void DecryptMessage_WhenGivenEncryptedMessage_ReturnsDecryptedMessage()
        {
            // Arrange
            var decryptor = new Decryptor();
            string encryptedMessage = "Khoor/#Zruog1";

            // Act
            var decryptedMessage = decryptor.DecryptMessage(encryptedMessage);

            // Assert
            Assert.IsNotNull(decryptedMessage);
            Assert.AreEqual("Hello, World!", decryptedMessage);
        }
    }
}
