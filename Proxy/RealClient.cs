namespace Proxy
{
    internal class RealClient : IClient
    {
        private string Data;

        public RealClient()
        {
            Console.WriteLine("Initialized a new Real Client");
            Data = "Hello, World!";
        }

        public string GetData() => Data;
    }
}
