using FluentValidation;


namespace CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike
{
    public class CreateMotorbikeValidator : AbstractValidator<CreateMotorbikeCommand>
    {
        public CreateMotorbikeValidator()
        {
            RuleFor(p => p.Brand).NotEmpty().WithMessage("Brand is required field");
            RuleFor(p => p.Brand).NotNull().WithMessage("Brand is required field");
            RuleFor(p => p.Brand).MinimumLength(3).WithMessage("Brand must be at least 3 characters");

            RuleFor(p => p.Model).NotEmpty().WithMessage("Model name is required field");
            RuleFor(p => p.Model).NotNull().WithMessage("Model name is required field");
            RuleFor(p => p.Model).MinimumLength(3).WithMessage("Model name must be at least 3 characters");

            RuleFor(p => p.Power).NotEmpty().WithMessage(" Power is required field");
            RuleFor(p => p.Power).NotNull().WithMessage(" power is required field");
            RuleFor(p => p.Power).GreaterThan(0).WithMessage(" power must be greater than 0 ");

            RuleFor(p => p.Price).NotEmpty().WithMessage(" Price is required field");
            RuleFor(p => p.Price).NotNull().WithMessage("Price is required field");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater than 0 ");
        }
    }
}

