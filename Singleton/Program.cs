using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        SingletonClass s1 = SingletonClass.Instance;
        SingletonClass s2 = SingletonClass.Instance;

        if(s1.GetHashCode() == s2.GetHashCode())
        {
            Console.WriteLine($"Same hashcode :) -> {s1.GetHashCode()} : {s2.GetHashCode()}");
        }else
        {
            Console.WriteLine($"Not the same hashcode :( -> {s1.GetHashCode()} : {s2.GetHashCode()}");
        }

        if(s1.Equals(s2))
        {
            Console.WriteLine("Singleton work's :)");
        }else
        {
            Console.WriteLine("Singleton is not working :(");
        }
    }
}