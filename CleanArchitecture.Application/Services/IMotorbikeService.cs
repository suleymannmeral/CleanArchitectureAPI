using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;
using CleanArchitecture.Domain.Entities;
using CleanArhcitecture.Shared.Models;

namespace CleanArchitecture.Application.Services
{
    public  interface IMotorbikeService
    {
        Task CreateAsync(CreateMotorbikeCommand request, CancellationToken cancellationToken);
    }
}
