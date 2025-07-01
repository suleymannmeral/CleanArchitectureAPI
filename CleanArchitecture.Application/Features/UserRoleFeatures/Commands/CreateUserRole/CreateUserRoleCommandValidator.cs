using FluentValidation;


namespace CleanArchitecture.Application.Features.UserRoleFeatures.Commands.CreateUserRole;

public sealed class CreateUserRoleCommandValidator :
    AbstractValidator<CreateUserRoleCommand>
{
    public CreateUserRoleCommandValidator()
    {
        RuleFor(p=>p.UserId).NotEmpty().WithMessage("User is required field");
        RuleFor(p=>p.UserId).NotNull().WithMessage("User is required field");
        RuleFor(p=>p.RoleId).NotEmpty().WithMessage("Role is required field");
        RuleFor(p=>p.RoleId).NotNull().WithMessage("Role is required field");
    }
}
