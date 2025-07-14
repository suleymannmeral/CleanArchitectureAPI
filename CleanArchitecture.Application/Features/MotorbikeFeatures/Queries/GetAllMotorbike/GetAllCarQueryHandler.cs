using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArhcitecture.Shared.Models;
using MediatR;


namespace CleanArchitecture.Application.Features.MotorbikeFeatures.Queries.GetAllMotorbike;

public sealed class GetAllCarQueryHandler : IRequestHandler<GetAllMotorbikeQuery, PaginationResult<Motorbike>>
{
    private readonly IMotorbikeService _motorbikeService;

    public GetAllCarQueryHandler(IMotorbikeService motorbikeService)
    {
        _motorbikeService = motorbikeService;
    }

    public async Task<PaginationResult<Motorbike>> Handle(GetAllMotorbikeQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Motorbike> motorbike = await _motorbikeService.GetAllAsync(request, cancellationToken);
        return motorbike;
    }
}
