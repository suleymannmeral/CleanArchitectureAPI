using AutoMapper;
using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArhcitecture.Shared.Extensions;
using CleanArhcitecture.Shared.Models;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Services;

public sealed class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CarService( IMapper mapper, ICarRepository carRepository, IUnitOfWork unitOfWork)
    {
        
        _mapper = mapper;
        _carRepository = carRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
     
        Car car = _mapper.Map<Car>(request);
        //await _appContext.Set<Car>().AddAsync(car,cancellationToken);
        //await _appContext.SaveChangesAsync(cancellationToken);
        await _carRepository.AddAsync(car,cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<PaginationResult<Car>> GetAllAsync(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Car> cars = await _carRepository
            .Where(p => p.Name.ToLower().Contains(request.Search.ToLower()))
            .ToPagedListAsync(request.PageNumber,request.PageSize,cancellationToken); 
           
        return cars;
    }
}
