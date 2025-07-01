using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Authorization;
using CleanArchitecture.Presentation.Abstraction;
using CleanArhcitecture.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public sealed class CarsController : ApiController
{
    public CarsController(IMediator mediator) : base(mediator)
    {
    }

    [RoleFilter("Admin")]
    [HttpPost("[action]")]
    public async Task<IActionResult>Create(CreateCarCommand request,CancellationToken cancellationToken)
    {
       MessageResponse response= await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [RoleFilter("Moderator")]
    [HttpPost("[action]")]

    public async Task<IActionResult> GetAll(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Car> response = await _mediator.Send(request,cancellationToken);
        return Ok(response);
    }   


}
