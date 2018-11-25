namespace VmEcommerceMapper.Dtos.Premiums
{

    public class PremiumsCalculationDto
    {
        public PremiumsCalculationDto()
        {
            this.drivers = new Drivers();
            this.insuredObject = new Insuredobject();
        }


        public Drivers drivers { get; set; }
        public Insuredobject insuredObject { get; set; }
    }
}
