using System;

namespace VmEcommerceMapper.Dtos.VmEcommerce
{
    public class VehicleDto
    {
        public string canton { get; set; }
        public string usage { get; set; }
        public int isnVehicule { get; set; }
        public string eurotax { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string registrationNumber { get; set; }
        public string homiologationNumber { get; set; }
        public int initialPrice { get; set; }
        public string licensePlate { get; set; }
        public DateTime dateOfFirstRegistration { get; set; }
        public string energyClass { get; set; }
        public bool leasing { get; set; }
        public bool under10000KmsPerYear { get; set; }
        public bool hasHomeGarage { get; set; }
        public bool hasGlassBreakageOnHeadlights { get; set; }
    }
}