using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using HrLeaveManagement.Application.contracts.persistence;

namespace HrLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesType
{
    public class GetLeaveTypeQueryHandler
        : IRequestHandler<GetLeaveTypeQuery, List<LeaveTypeDto>>
    {

        private readonly IMapper mapper;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public GetLeaveTypeQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this.mapper = mapper;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeQuery request, CancellationToken cancellationToken)
        {
            var leaveTypes = await leaveTypeRepository.GetAsync();

            var data = mapper.Map<List<LeaveTypeDto>>(leaveTypes);

            return data;

        }
    }
}
