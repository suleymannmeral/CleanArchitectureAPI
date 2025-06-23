using FluentValidation;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Car name is required field");
        RuleFor(p => p.Name).NotNull().WithMessage("Car name is required field");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("Car name must be at least 3 characters");

        RuleFor(p => p.Model).NotEmpty().WithMessage("Model name is required field");
        RuleFor(p => p.Model).NotNull().WithMessage("Model name is required field");
        RuleFor(p => p.Model).MinimumLength(3).WithMessage("Model name must be at least 3 characters");

        RuleFor(p => p.EnginePower).NotEmpty().WithMessage("Engine Power is required field");
        RuleFor(p => p.EnginePower).NotNull().WithMessage("Engine power is required field");
        RuleFor(p => p.EnginePower).GreaterThan(0).WithMessage("Engine power must be greater than 0 ");



    }
}
