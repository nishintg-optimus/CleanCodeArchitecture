using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementDomain;
using HrLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesType;
using HrLeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails

namespace HrLeaveManagement.Application.mappingProfiles
{ 
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
           CreateMap<LeaveTypeDto,LeaveType>().ReverseMap();
           CreateMap<LeaveType,LeaveTypeDetailDto>().ReverseMap();
        }
    }
}
 