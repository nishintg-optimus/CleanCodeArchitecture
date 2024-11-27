using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Commands.CommandLeaveType
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {

        public string Name
        {
            get; set;
        } = string.Empty;

        public int DefaultDays
        { 
            get; set;
        }












    }
}
