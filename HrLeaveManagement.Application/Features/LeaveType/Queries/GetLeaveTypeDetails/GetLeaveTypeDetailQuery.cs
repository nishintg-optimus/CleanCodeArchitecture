using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public record GetLeaveTypeDetailQuery(int Id) : IRequest<LeaveTypeDetailDto>;


}
