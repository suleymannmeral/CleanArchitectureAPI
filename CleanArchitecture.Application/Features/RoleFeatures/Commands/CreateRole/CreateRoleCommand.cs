﻿using CleanArchitecture.Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.RoleFeatures.Commands.CreateRole
{
     public sealed record CreateRoleCommand(
         string Name):IRequest<MessageResponse>;
   
}
