using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HrLeaveManagement.Application.contracts.persistence;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand,Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }  
        
        public async Task<Unit> Handle(DeleteLeaveTypeCommand request,CancellationToken cancellation)
        {

            //validate incoming data

            //convert to domain entity object
            var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);


            //verify

            //add to database

            foreach(var leaveType in leaveTypeToDelete)
                await _leaveTypeRepository.DeleteAsync(leaveType);
           

            return Unit.Value;

        }
    }
}
