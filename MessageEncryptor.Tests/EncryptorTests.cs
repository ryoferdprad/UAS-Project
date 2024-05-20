using NUnit.Framework;

namespace MessageEncryptor.Tests
{
    public class EncryptorTests
    {
        [Test]
        public void EncryptMessage_WhenGivenMessage_ReturnsEncryptedMessage()
        {
            // Arrange
            var encryptor = new Encryptor();
            string message = "Hello, World!";

            // Act
            var encryptedMessage = encryptor.EncryptMessage(message);

            // Assert
            Assert.IsNotNull(encryptedMessage);
            Assert.AreNotEqual(message, encryptedMessage);
        }
    }
}
