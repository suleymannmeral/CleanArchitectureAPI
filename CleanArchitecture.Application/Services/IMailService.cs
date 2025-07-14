using CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Queries.GetAllMotorbike;
using CleanArchitecture.Domain.Entities;
using CleanArhcitecture.Shared.Models;
using System.Net.Mail;

namespace CleanArchitecture.Application.Services;

public  interface IMailService
{
    Task SendMailAsync(List<string> emails, string subject, string body, List<Attachment>? attachments=null);

}
