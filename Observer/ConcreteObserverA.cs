using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ConcreteObserver : IObserver
    {
        public void Updated(ISubject subject)
        {
            if(((Subject)subject).State < 3)
            {
                Console.WriteLine("ConcreteObserver: Reacted to the event.");
            }
        }
    }
}
