using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services
{
    internal class BlueService : IAbstractService
    {
        public BlueService()
        {
            Console.WriteLine("New blue service!!");
        }

        public string SomeServiceFunction()
        {
            return "Some ** blue ** service";
        }
    }
}
