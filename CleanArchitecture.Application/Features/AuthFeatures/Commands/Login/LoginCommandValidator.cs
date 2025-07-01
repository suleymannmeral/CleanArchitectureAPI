
using FluentValidation;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Login;

public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(p => p.UserNameOrEmail).NotEmpty().WithMessage("UserName or mail are required field");
        RuleFor(p => p.UserNameOrEmail).NotNull().WithMessage("UserName must not be null");
        RuleFor(p => p.UserNameOrEmail).MinimumLength(3).WithMessage("UserName or mail must be at least 3 characters");
        RuleFor(p => p.Password).NotEmpty().WithMessage("UserName must be at least 3 characters");
        RuleFor(p => p.Password).NotNull().WithMessage("UserName must be at least 3 characters");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Password must have at least 1 uppercase character");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Password must have at least 1 lowercase character");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Password must have at least 1 number character");
    }
}
