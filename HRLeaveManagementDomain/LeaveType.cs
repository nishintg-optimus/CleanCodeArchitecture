using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLeaveManagementDomain.common;

namespace HRLeaveManagementDomain
{
    public class LeaveType:  BaseEntity
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public int DefaultDays
        {
            get; set;
        }
    }
}
