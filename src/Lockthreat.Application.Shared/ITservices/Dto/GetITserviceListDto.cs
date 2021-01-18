using Abp.Application.Services.Dto;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessServices.Dto;
using Lockthreat.Employee.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.ITservices.Dto
{   
  public class GetITserviceListDto : EntityDto<long>
        {
            public string ITServicesId { get; set; }

            public string ITServiceName { get; set; }

            public int? ServiceTypeId { get; set; }
            public DynamicEntityProperty ServiceType { get; set; }

            public int? ServiceClassificationId { get; set; }
            public DynamicEntityProperty ServiceClassification { get; set; }

            public long? LockThreatOrganizationId { get; set; }
            public GetOrganizationDto LockThreatOrganization { get; set; }

            public long? ITServiceOwnerId { get; set; }
            public GetEmployeeForEditDto ITServiceOwner { get; set; }

            public long? BusinessUnitId { get; set; }
            public BusinessUnitPrimaryDto BusinessUnit { get; set; }

            public int? ConfidentialityId { get; set; }
            public DynamicEntityProperty Confidentiality { get; set; }
            public int? IntegrityId { get; set; }
            public DynamicEntityProperty Integrity { get; set; }

            public int? OthersId { get; set; }
            public DynamicEntityProperty Others { get; set; }

            public int? AvailibilityId { get; set; }
            public DynamicEntityProperty Availibility { get; set; }


    }
    
}
