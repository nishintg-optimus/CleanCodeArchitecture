using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLeaveManagementDomain.common;

namespace HRLeaveManagementDomain
{
    public class LeaveAllocation : BaseEntity
    {
        public int Id
        {
            get; set;
        }

        public int NumberOfDays
        {
            get; set;
        }

        public LeaveType? LeaveType
        { 
            get; set;
        }

        public int LeaveTypeId
        { 
            get; set; 
        }

        public int Period
        {
            get;
            set;
        }
    }
}
