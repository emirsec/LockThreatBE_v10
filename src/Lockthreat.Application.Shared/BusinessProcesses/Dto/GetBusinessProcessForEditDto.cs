using Abp.DynamicEntityProperties;
using Lockthreat.Employee.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lockthreat.BusinessProcesses.Dto
{
    public class GetBusinessProcessForEditDto
    {
        public int? Id { get; set; }
        public int? TenantId { get; set; } 
        public string BusinessProcessId { get; set; } 
        [Required]
        public string BusinessProcessName { get; set; } 
        public int? StatusId { get; set; }
        public DynamicEntityProperty Status { get; set; } 
        public string Description { get; set; } 
        public int? ProcessTypeId { get; set; }
        public DynamicEntityProperty ProcessType { get; set; } 
        public int? SLAApplicableId { get; set; }
        public DynamicEntityProperty SLAApplicable { get; set; } 
        public int? ActivityCycleId { get; set; }
        public DynamicEntityProperty ActivityCycle { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; } 
        public string PostalCode { get; set; }
        public int? CountryId { get; set; }
        public DynamicEntityProperty Country { get; set; }
        public long? CompanyNameId { get; set; }
        public GetOrganizationForEditDto CompanyName { get; set; } 
        public long? ProcessManagerId { get; set; }
        public GetEmployeeForEditDto ProcessManager { get; set; } 
        public long? ProcessOwnerId { get; set; }
        public GetEmployeeForEditDto ProcessOwner { get; set; } 
        public long? BusinessUnitOwnerId { get; set; }
        public GetEmployeeForEditDto BusinessUnitOwner { get; set; } 
        public int? RegulatoryMandateId { get; set; }
        public DynamicEntityProperty RegulatoryMandate { get; set; } 
        public int? ProcessPriorityId { get; set; }
        public DynamicEntityProperty ProcessPriority { get; set; } 
        public int? OthersId { get; set; }
        public DynamicEntityProperty Others { get; set; } 
        public int? ConfidentialityId { get; set; }
        public DynamicEntityProperty Confidentiality { get; set; } 
        public int? ReviewPeriodId { get; set; }
        public DynamicEntityProperty ReviewPeriod { get; set; } 
        public int? IntergrityId { get; set; }
        public DynamicEntityProperty Intergrity { get; set; } 
        public int? AvailibilityId { get; set; }
        public DynamicEntityProperty Availibility { get; set; } 
        public string Documents { get; set; }
    }
}
