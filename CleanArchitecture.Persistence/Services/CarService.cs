using AutoMapper;
using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;

namespace CleanArchitecture.Persistence.Services;

public sealed class CarService : ICarService
{
    private readonly AppDbContext _appContext;
    private readonly IMapper _mapper;

    public CarService(AppDbContext appContext, IMapper mapper)
    {
        _appContext = appContext;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        //Car car = new Car()
        //{
        //    Name = request.Name,
        //    Model = request.Model,
        //    Power = request.EnginePower,

        //};<
        Car car = _mapper.Map<Car>(request);
        await _appContext.Set<Car>().AddAsync(car,cancellationToken);
        await _appContext.SaveChangesAsync(cancellationToken);
    }
}
