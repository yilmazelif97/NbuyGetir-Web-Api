using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Notifications
{
    /// <summary>
    /// emaile eklene dosyalar 
    /// </summary>
    public class EmailAttachment
    {
        /// <summary>
        /// Base64 formatında veri; resim, excel, word gibi dosyalar olabilir. 
        /// </summary>
        public string Base64 { get; set; }

        /// <summary>
        /// Dosya byte[] olarak email saf halde gönderilebilir. 
        /// </summary>
        public byte[] File { get; set; }


    }


    public interface IEmailSender
    {
        /// <summary>
        /// Email atma işlemleri için bu servisi kullanacağız 
        /// </summary>
        /// <param name="to"> aralarında , olarak tek bir string ile birden fazla kişiye mail atılabilir. a@gmail.com, b@gmail.com gibi </param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="ccc"> aralarında , konularak birden fazla kişi ccc ye eklenebilir d</param>
        /// <param name="emailAttachments"></param>
        /// <returns></returns>
        Task SendEmailAsync(string to, string subject, string message, string ccc, List<EmailAttachment> emailAttachments= null );


    }
}
