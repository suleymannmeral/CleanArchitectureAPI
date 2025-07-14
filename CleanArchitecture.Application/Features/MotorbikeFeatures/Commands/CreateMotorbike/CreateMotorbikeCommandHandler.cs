

using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;

public sealed class CreateMotorbikeCommandHandler : IRequestHandler<CreateMotorbikeCommand, MessageResponse>
{
    private readonly IMotorbikeService _motorbikeService;

    public CreateMotorbikeCommandHandler(IMotorbikeService motorbikeService)
    {
        _motorbikeService = motorbikeService;
    }

    public async Task<MessageResponse> Handle(CreateMotorbikeCommand request, CancellationToken cancellationToken)
    {
      
        await _motorbikeService.CreateAsync(request, cancellationToken);

        return new("Motorbike registered successfully");
    }
}
