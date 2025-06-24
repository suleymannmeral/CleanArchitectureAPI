using CleanArchitecture.Domain.Entities;
using MediatR;


namespace CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar
{
    public sealed class GetAllCarQuery(): IRequest<IList<Car>>
    {
    }
}
