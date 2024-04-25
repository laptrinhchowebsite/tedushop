using System.Net.Mail;

namespace TeduShop.Common
{
    public class MailHelper
    {
        public static bool SendMail(string toEmail, string subject, string content)
        {
            try
            {
                var host = ConfigHelper.GetByKey("SMTPHost");
                var port = int.Parse(ConfigHelper.GetByKey("SMTPPort"));
                var fromEmail = ConfigHelper.GetByKey("FromEmailAddress");
                var password = ConfigHelper.GetByKey("FromEmailPassword");
                var fromName = ConfigHelper.GetByKey("FromName");

                var smtpClient = new SmtpClient(host, port)
                {
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromEmail, password),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = true,
                    Timeout = 100000
                };

                var mail = new MailMessage
                {
                    Body = content,
                    Subject = subject,
                    From = new MailAddress(fromEmail, fromName)
                };

                mail.To.Add(new MailAddress(toEmail));
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                smtpClient.Send(mail);

                return true;

                //MailMessage message = new MailMessage();
                //message.From = new MailAddress("baotinsoft40@gmail.com");
                //message.To.Add("roadtofinishwebsite@gmail.com");
                //message.Subject = subject;
                //message.IsBodyHtml = true;
                //message.Body = body;
                //using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                //{
                //    smtpClient.UseDefaultCredentials = false;
                //    smtpClient.Credentials = (ICredentialsByHost)new NetworkCredential("baotinsoft40@gmail.com", "zuvtjgqasskxocxk");
                //    smtpClient.EnableSsl = true;
                //    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                //    smtpClient.Send(message);
                //}

            }
            catch (SmtpException smex)
            {
                return false;
            }
        }
    }
}