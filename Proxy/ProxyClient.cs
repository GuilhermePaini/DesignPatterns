using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProxyClient : IClient
    {
        private RealClient? Client;

        public ProxyClient() 
        {
            Console.WriteLine("Initialized a Proxy Client");
        }

        public string GetData()
        {
            // lazy loading
            Client = new RealClient();
            return Client.GetData();
        }
    }
}
