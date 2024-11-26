using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementDomain;

namespace HrLeaveManagement.Application.mappingProfiles
{ 
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto,LeaveType>().ReverseMap();
        }
    }
}
 