using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MessageEncryptor;
using MessageCrypterApp.MessageEncryptor;



namespace MessageCrypterApp.Pages
{
    public class EncryptModel : PageModel
    {
        public string EncryptedMessage { get; private set; }

        public void OnPost(string messageToEncrypt)
        {
            var encryptor = new Encryptor();
            EncryptedMessage = encryptor.EncryptMessage(messageToEncrypt);
        }
    }
}
