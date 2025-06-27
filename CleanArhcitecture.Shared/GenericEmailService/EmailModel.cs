using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArhcitecture.Shared.GenericEmailService
{
    public sealed record EmailModel<TAttachment>(
     EmailConfigurations Configurations,
     string FromEmail,
     List<string> ToEmails,
     string Subject,
     string Body,
     List<TAttachment>? Attachments = null);
}
