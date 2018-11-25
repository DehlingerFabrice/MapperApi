using System.Collections.Generic;

namespace VmEcommerceMapper.Dtos.Premiums
{
    public class Insuredobject
    {
        public Insuredobject()
        {
            this.questions_N = new List<Questions_N>();
            this.arguments_A = new List<Argument_A>();
            this.arguments_N = new List<Argument_N>();
            this.coverages = new List<Coverage>();


        }
        public List<Questions_N> questions_N { get; set; }
        public List<Argument_A> arguments_A { get; set; }
        public List<Argument_N> arguments_N { get; set; }
        public List<Coverage> coverages { get; set; }
    }
}