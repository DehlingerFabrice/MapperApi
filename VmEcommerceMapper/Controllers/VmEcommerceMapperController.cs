

using Microsoft.AspNetCore.Mvc;

using VmEcommerceMapper.Dtos.Premiums;
using VmEcommerceMapper.Dtos.VmEcommerce;
using VmEcommerceMapper.Mapping;

namespace VmEcommerceMapper.Controllers
{
    public class VmEcommerceMapperController : ControllerBase
    {

        // POST api/values
        [HttpPost]
        public PremiumsCalculationDto Post([FromBody] EcommerceVmDto ecommerceVm)
        {
            var MapperService = new PremiumsCalculationMapperService();

            return MapperService.MappeEcommerce(ecommerceVm);

        }
    }
}
