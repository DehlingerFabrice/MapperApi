using System;

namespace VmEcommerceMapper.Dtos.VmEcommerce
{

    public class EcommerceVmDto
    {
        public bool hasAnnualTerminationClause { get; set; }
        public DateTime contractEffectiveAt { get; set; }
        public int contractDuration { get; set; }
        public MaindriverDto mainDriver { get; set; }
        public VehicleDto vehicle { get; set; }
    }
}
