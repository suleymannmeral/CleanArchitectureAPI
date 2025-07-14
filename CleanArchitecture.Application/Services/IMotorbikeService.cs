
using CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Queries.GetAllMotorbike;
using CleanArchitecture.Domain.Entities;
using CleanArhcitecture.Shared.Models;

namespace CleanArchitecture.Application.Services;

public  interface IMotorbikeService
{
    Task CreateAsync(CreateMotorbikeCommand request, CancellationToken cancellationToken);
    Task<PaginationResult<Motorbike>> GetAllAsync(GetAllMotorbikeQuery request, CancellationToken cancellationToken);

}
