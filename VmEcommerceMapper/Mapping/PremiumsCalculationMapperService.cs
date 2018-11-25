using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VmEcommerceMapper.Dtos.Premiums;
using VmEcommerceMapper.Dtos.VmEcommerce;

namespace VmEcommerceMapper.Mapping
{
    public class PremiumsCalculationMapperService
    {
        public PremiumsCalculationDto MappeEcommerce(EcommerceVmDto ecommerceVm)
        {
            var premiumCalculation = new PremiumsCalculationDto();

            // Critères Drivers *******
            // Critères textes
            // Date de naissance = 63
            premiumCalculation.drivers.Arguments_A.Add(new Argument_A { id = 63, value = ecommerceVm.mainDriver.birthdate.ToString("yyyy-MM-dd")});
            // Nationalité = 65
            premiumCalculation.drivers.Arguments_A.Add(new Argument_A { id = 65, value = ecommerceVm.mainDriver.nationality });

            // Critères numériques
            // Sexe = 62
            premiumCalculation.drivers.Arguments_N.Add(new Argument_N{id = 62, value = ecommerceVm.mainDriver .title == "MR" ? 1 : 2});
            // Dérogation 70 ans = 69 -- NON par défaut = 2
            premiumCalculation.drivers.Arguments_N.Add(new Argument_N { id = 69, value = 2 });

            return premiumCalculation;

        }
    }
}
