﻿using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Authorization.Users.Dto;
using Lockthreat.Business.Dto;

using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.Employee.Dto
{
    public class EmployeeListDto : EntityDto<long>, IPassivable, IHasCreationTime
    {
        public string EmployeeId { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string CellPhone { get; set; }
        public string DirectPhone { get; set; } 
        public int? Age { get; set; } 
        public string ProfilePicture { get; set; } //stores Base 64 string 
        public bool IsNotifiedByEmail { get; set; }
        public int? EmployeeGradeId { get; set; }
        public DynamicEntityProperty EmployeeGrade { get; set; }
        public int? EmployeeTypeId { get; set; }
        public DynamicEntityProperty EmployeeType { get; set; }
        public long? LockThreatOrganizationId  { get; set; }
        public GetOrganizationForEditDto LockThreatOrganization { get; set; }
        public long? BusinessUnitId { get; set; }
        public GetBusinessUnitForEditDto BusinessUnit { get; set; }
        public int? RiskGroupId { get; set; }
        public DynamicEntityProperty RiskGroup { get; set; }
        public string EmployeePosition { get; set; }
        public long? UserId { get; set; }
        public UserEditDto User { get; set; }
        public string AccessCardId { get; set; } 
        public string CompanyId { get; set; } 
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
