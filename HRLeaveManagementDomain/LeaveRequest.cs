﻿using System.ComponentModel.DataAnnotations.Schema;
using HRLeaveManagementDomain.common;

namespace HRLeaveManagementDomain
{
    public class LeaveRequest : BaseEntity
    {
        public int Id
        {
            get; set;
        }

        public DateTime StartDate
        {
            get; set;
        }

        public DateTime EndDate
        {
            get; set;
        }

        //[ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType
        {
            get; set;
        }
        public int LeaveTypeId
        {
            get; set;
        }

        public DateTime DateRequested
        {
            get; set;
        }
        public string? RequestComments
        {
            get; set;

        }
        public bool? Approved
        {
            get;
            set;
        }

        public bool? Cancelled
        {
            get;
            set;
        }
        public string RequestingEmployeeId
        {
            get;
            set;
        } = string.Empty;
    }
}
