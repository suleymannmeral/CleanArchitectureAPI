using CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CleanArchitecture.Presentation.Controllers;

public sealed class MotorbikeController : ApiController
{
    public MotorbikeController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMotorbikeCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
