using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HrLeaveManagement.Application.contracts.persistence;
using HrLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesType;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailQueryHandler : IRequestHandler<GetLeaveTypeDetailQuery, LeaveTypeDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypeDetailQuery request, CancellationToken cancellationToken)
        {
            //query the database
            var leaveTypes = await _leaveTypeRepository.GetByIdAsync(request.Id);

            var data = _mapper.Map<LeaveTypeDetailDto>(leaveTypes);

            return data;

        }

    }
}