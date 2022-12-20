using Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        // chamada sem proxy
        IClient client = new RealClient();
        client.GetData();

        // chamada com proxy
        IClient another_client = new ProxyClient();
        another_client.GetData();
    }
}