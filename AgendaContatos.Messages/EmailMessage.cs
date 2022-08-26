using System.Net;
using System.Net.Mail;

namespace AgendaContatos.Messages
{
    /// <summary>
    /// Classe para envio de emails
    /// </summary>
    public class EmailMessage
    {
        #region Atributos

        private string _conta = "cotinaoresponda@outlook.com";
        private string _senha = "@Admin123456";
        private string _smtp = "smtp-mail.outlook.com";
        private int _porta = 587;

        #endregion

        //método para realizar o envio de um email
        public void SendMail(string emailTo, string subject, string body)
        {
            //criando o email que será enviado
            var mailMessage = new MailMessage(_conta, emailTo);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;

            //enviando o email
            var smtpClient = new SmtpClient(_smtp, _porta);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(_conta, _senha);
            smtpClient.Send(mailMessage);
        }

    }
}


