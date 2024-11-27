using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HrLeaveManagement.Application.contracts.persistence;
using MediatR;

using HRLeaveManagementDomain;

namespace HrLeaveManagement.Application.Features.LeaveType.Commands.CommandLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {

        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;


        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this._mapper = mapper;  
            this._leaveTypeRepository = leaveTypeRepository;
        }




        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //validte incomeing data

            //convert too domain entity object

            var leaveTypeToCreate = _mapper.Map<HRLeaveManagementDomain.LeaveType>(request);

            //add to databasse

            await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);

            //return record id
            return leaveTypeToCreate.Id;

        }
    }

    

}

