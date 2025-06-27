using CleanArchitecture.Application.Services;
using CleanArhcitecture.Shared.GenericEmailService;
using System.Net.Mail;

namespace CleanArchitecture.Infrastructure.Services;

public sealed class MailService : IMailService
{
    public async Task SendMailAsync(List<string>emails,string subject,string body,List<Attachment>? attachments)
    {
        EmailConfigurations configurations = new(
                                        Smtp: "smtp.gmail.com",
                                        Password: "fxsc tufz pdsw ppsa",
                                        Port: 587,
                                        SSL: true,
                                        Html: true);
        EmailModel<Attachment> model = new(
                                     Configurations: configurations,
                                     FromEmail: "lexvon53@gmail.com",
                                     ToEmails: emails,
                                     Subject: subject,
                                     Body: body,
                                     Attachments: attachments);
        await EmailService.SendEmailWithNetAsync(model);

      
    }
}
