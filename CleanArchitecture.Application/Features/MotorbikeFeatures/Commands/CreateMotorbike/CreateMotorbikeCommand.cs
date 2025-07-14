using CleanArchitecture.Domain.Dtos;
using MediatR;


namespace CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike
{
    public sealed record CreateMotorbikeCommand(
     string Brand,
     string Model,
    decimal Price,
     int Power
     ) : IRequest<MessageResponse>;





}
