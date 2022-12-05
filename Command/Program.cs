using Command;

internal class Program
{
    private static void Main(string[] args)
    {
        ReadWrite readWrite = new ReadWrite();

        ICommand read = new Read(readWrite);
        ICommand write = new Write(readWrite);

        Command.Stream stream = new Command.Stream();

        while(true)
        {
            Console.WriteLine("\nEnter commands (read/write/quit): ");

            string? command = Console.ReadLine();

            switch (command)
            {
                case "read":
                    stream.StoreAndExecute(read);
                    break;
                case "write":
                    stream.StoreAndExecute(write);
                    break;
                case "quit":
                    return;
                default:
                    Console.WriteLine("Invalid command");
                    break;

            }
        }
    }
}