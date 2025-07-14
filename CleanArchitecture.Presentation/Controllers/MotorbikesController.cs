using CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Queries.GetAllMotorbike;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Presentation.Abstraction;
using CleanArhcitecture.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CleanArchitecture.Presentation.Controllers;

public sealed class MotorbikesController : ApiController
{
    public MotorbikesController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMotorbikeCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> GetAll(GetAllMotorbikeQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Motorbike> response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }


}
