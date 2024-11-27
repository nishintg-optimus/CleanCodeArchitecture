using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HrLeaveManagement.Application.contracts.persistence;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType
{
        public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand,Unit>
    {
        private readonly IMapper _mappers;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public UpdateLeaveTypeCommandHandler(IMapper mappers, ILeaveTypeRepository leaveTypeRepository)
        {
            _mappers = mappers;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request,CancellationToken cancellation)
        {
            //validate incoming data

            //convert to domain entity object
            var leaveTypeToUpdate = _mappers.Map<HRLeaveManagementDomain.LeaveType>(request);

            //add to database
            await leaveTypeRepository.UpdateAsync(leaveTypeToUpdate);

            return Unit.Value;

        }
    }
}
