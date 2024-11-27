using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesType
{
    public record GetLeaveTypeQuery : IRequest<List<LeaveTypeDto>>;
}
    
