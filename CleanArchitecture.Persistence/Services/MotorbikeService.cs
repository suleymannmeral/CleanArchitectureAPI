using AutoMapper;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Queries.GetAllMotorbike;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistence.Repositories;
using CleanArhcitecture.Shared.Extensions;
using CleanArhcitecture.Shared.Models;
using GenericRepository;


namespace CleanArchitecture.Persistence.Services;

public sealed class MotorbikeService : IMotorbikeService
{
    private readonly IMotorbikeRepository _motorbikeRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MotorbikeService(IMotorbikeRepository motorbikeRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _motorbikeRepository = motorbikeRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateMotorbikeCommand request, CancellationToken cancellationToken)
    {
        Motorbike motorbike = _mapper.Map<Motorbike>(request);
        await _motorbikeRepository.AddAsync(motorbike, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<PaginationResult<Motorbike>> GetAllAsync(GetAllMotorbikeQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Motorbike> motorbikes = await _motorbikeRepository
            .Where(p => p.Brand.ToLower().Contains(request.Search.ToLower()))
            .ToPagedListAsync(request.PageNumber, request.PageSize, cancellationToken);

        return motorbikes;
    }
}
