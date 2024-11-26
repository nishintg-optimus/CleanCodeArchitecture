using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesType
{
    public class LeaveTypeDto
    {
        public int Id { get; set; }
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

