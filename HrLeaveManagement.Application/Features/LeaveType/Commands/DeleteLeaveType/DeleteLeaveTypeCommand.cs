using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType
{
    public class DeleteLeaveTypeCommand : IRequestHandler<DeleteLeaveTypeCommand,>
    {
        public int Id 
        { get; set; }
    }
}
