
using Abp.Domain.Repositories;
using Abp.DynamicEntityProperties;
using Lockthreat.DynamicEntityProperties.Dto;
using Lockthreat.OrganizationSetup.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.UI;
namespace Lockthreat.DynamicParameterAll
{
 public  class DynamicParameterAppService : IDynamicParameterAppService
    {
        private readonly IRepository<DynamicPropertyValue> _DynamicParameterValueRepository;
        private readonly IRepository<DynamicProperty> _dynamicParameterManager;

        public DynamicParameterAppService(
          IRepository<DynamicPropertyValue> DynamicParameterValueRepository,
          IRepository<DynamicProperty> dynamicParameterManager
          )
        {
            _DynamicParameterValueRepository = DynamicParameterValueRepository;
            _dynamicParameterManager = dynamicParameterManager;
        }


        

    }
}
