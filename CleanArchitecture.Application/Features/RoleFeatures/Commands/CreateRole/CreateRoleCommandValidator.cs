using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.RoleFeatures.Commands.CreateRole
{
    internal class CreateRoleCommandValidator :
        AbstractValidator<CreateCarCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(p=>p.Name).NotEmpty().WithMessage("Role Name is required field");
            RuleFor(p=>p.Name).NotNull().WithMessage("Role Name is required field");

        }
    }
}
