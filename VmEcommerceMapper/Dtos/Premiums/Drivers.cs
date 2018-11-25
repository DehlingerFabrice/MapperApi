using System.Collections.Generic;

namespace VmEcommerceMapper.Dtos.Premiums
{
    public class Drivers
    {
        public Drivers()
        {
            this.Arguments_A = new List<Argument_A>();
            this.Arguments_N = new List<Argument_N>();

        }
        public List<Argument_A> Arguments_A { get; set; }
        public List<Argument_N> Arguments_N { get; set; }
    }
}