using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services
{
    internal class RedService : IAbstractService
    {
        public RedService()
        {
            Console.WriteLine("New red service!!");
        }

        public string SomeServiceFunction()
        {
            return "Some ** red ** service";
        }
    }
}
