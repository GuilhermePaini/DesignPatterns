using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class PositiveProcessor : Processor
    {
        public PositiveProcessor(Processor? next = null) : base(next)
        {
        }

        public override void Process(Number request)
        {
            if (request.getNumber() > 0)
                Console.WriteLine($"PositiveProcessor: {request.getNumber()}");
            else
                base.Process(request);
        }
    }
}
