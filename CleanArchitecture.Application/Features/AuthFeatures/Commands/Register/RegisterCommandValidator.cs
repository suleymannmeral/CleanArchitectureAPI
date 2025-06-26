using FluentValidation;


namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;

public sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(p => p.Email).NotEmpty().WithMessage("Email is required field");
        RuleFor(p => p.Email).NotNull().WithMessage("Email must not be null");
        RuleFor(p => p.Email).EmailAddress().WithMessage("Your email adress is invalid");
        RuleFor(p => p.UserName).NotEmpty().WithMessage("UserName is required field");
        RuleFor(p => p.UserName).NotNull().WithMessage("UserName must not be null");
        RuleFor(p => p.UserName).MinimumLength(3).WithMessage("UserName must be at least 3 characters");
        RuleFor(p => p.Password).NotEmpty().WithMessage("UserName must be at least 3 characters");
        RuleFor(p => p.Password).NotNull().WithMessage("UserName must be at least 3 characters");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Password must have at least 1 uppercase character");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Password must have at least 1 lowercase character");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Password must have at least 1 number character");
    }
}
