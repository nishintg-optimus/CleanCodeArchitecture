using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public string Name
        {
            get; set;
        }=string.Empty;

        public int DefaultDays
        {
            get;
            set;
        }

        public int Id
        { get; set; }
    }
}
