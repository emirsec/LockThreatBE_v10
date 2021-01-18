using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessServices.Dto;
using Lockthreat.Employee.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.FacilitieDatacenters.Dto
{
   public  class GetFacilitiesDatacenterListDto : EntityDto<long>
    {
        public int? TenantId { get; set; }
        public string FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityAddressOne { get; set; }
        public string FacilityAddressTwo { get; set; }

        public int? FacilityTypeId { get; set; }
        public DynamicEntityProperty FacilityType { get; set; }
        public string State { get; set; }

        public string City { get; set; }
        public string PostalCode { get; set; }
        public int? CountryId { get; set; }
        public DynamicEntityProperty Country { get; set; }

        public long? LockThreatOrganizationId { get; set; }
        public GetOrganizationForEditDto LockThreatOrganization { get; set; }
        public long? BusinessUnitOwnerId { get; set; }
        public BusinessUnitPrimaryDto BusinessUnitOwner { get; set; }

        public long? BusinessUnitGaurdianId { get; set; }
        public BusinessUnitPrimaryDto BusinessUnitGaurdian { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicEntityProperty Confidentiality { get; set; }
        public int? IntegrityId { get; set; }
        public DynamicEntityProperty Integrity { get; set; }
        public int? AvailibilityId { get; set; }
        public DynamicEntityProperty Availibility { get; set; }
        public int? OthersId { get; set; }
        public DynamicEntityProperty Others { get; set; }

    }
}
