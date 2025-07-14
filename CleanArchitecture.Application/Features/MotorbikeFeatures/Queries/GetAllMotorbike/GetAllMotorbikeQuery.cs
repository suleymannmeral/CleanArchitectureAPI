using CleanArchitecture.Domain.Entities;
using CleanArhcitecture.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.MotorbikeFeatures.Queries.GetAllMotorbike
{
    public sealed record GetAllMotorbikeQuery(
        int PageNumber = 1,
        int PageSize = 10,
        string Search = ""
    ) : IRequest<PaginationResult<Motorbike>>;
        
    
    
}
