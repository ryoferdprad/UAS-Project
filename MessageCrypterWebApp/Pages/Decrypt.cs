using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MessageDecryptor;
using MessageCrypterApp.MessageDecryptor;


namespace MessageCrypterApp.Pages
{
    public class DecryptModel : PageModel
    {
        public string DecryptedMessage { get; private set; }

        public void OnPost(string messageToDecrypt)
        {
            var decryptor = new Decryptor();
            DecryptedMessage = decryptor.DecryptMessage(messageToDecrypt);
        }
    }
}
