using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Org.BouncyCastle.Asn1.Ocsp;
using UlamCommon;

namespace UlamRandomizerBusinessLogic
{
    public class EmailBL
    {
        private readonly IConfiguration _configuration;

        public EmailBL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task sendConfirmationEmail(string StringEmail,string Username)
        {

            try
            {
                using var email = new MimeMessage();
                email.From.Add(new MailboxAddress("Ulam Randomizer", "donotreply@demomail.com"));
                email.To.Add(new MailboxAddress(Username, StringEmail));

                var builder = new BodyBuilder();

                email.Subject = "Welcome to AnUlam!";
                builder.TextBody = $"Thank you for creating an Account {Username}, hop on and let's figure out your next dish!";

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                //smtp.Connect("sandbox.smtp.mailtrap.io", 2525, false);
                smtp.Connect(
                    _configuration["EmailSettings:SmtpHost"],
                    int.Parse(_configuration["EmailSettings:SmtpPort"]),
                    MailKit.Security.SecureSocketOptions.StartTls);

                smtp.Authenticate(
                    _configuration["EmailSettings:SmtpUsername"],
                    _configuration["EmailSettings:SmtpPassword"]);
                smtp.Send(email);

                smtp.Disconnect(true);
                Console.WriteLine("Email sent successfully!");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task<bool> sendFavouritesEmail(string StringEmail, string Username, List<Ulam> Favorites)
        {
            try
            {
                using var email = new MimeMessage();
                email.From.Add(new MailboxAddress("Ulam Randomizer", "donotreply@demomail.com"));
                email.To.Add(new MailboxAddress(Username, StringEmail));

                var builder = new BodyBuilder();
                var StringBuild = new System.Text.StringBuilder();
                
                email.Subject = "Here's your favorites!";
                StringBuild.AppendLine("Here are your current favorite dishes: \n");

                foreach (Ulam ulam in Favorites)
                {
                    StringBuild.AppendLine($"- {ulam.UlamName}");    
                }

                //builder.TextBody = $"Here are your current favorite dishes: \n";
                
                builder.TextBody = StringBuild.ToString();

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect("sandbox.smtp.mailtrap.io", 2525, false);
                smtp.Authenticate("86e163b69f42f6", "4b161216c2d723");
                smtp.Send(email);

                smtp.Disconnect(true);
                Console.WriteLine("Email sent successfully!");
                return true;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
