using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class AnotherConcreteObserver : IObserver
    {
        public void Updated(ISubject subject)
        {
            if (((Subject)subject).State == 0 || ((Subject)subject).State >= 2)
            {
                Console.WriteLine("AnotherConcreteObserver: Reacted to the event.");
            }
        }
    }
}
