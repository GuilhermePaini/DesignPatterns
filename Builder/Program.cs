// See https://aka.ms/new-console-template for more information
using Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        IComputerBuilder builder = new ComputerBuilder();

        builder.AddMotherBoard();
        builder.AddCPU();
        builder.AddHD();
        builder.AddPowerSupply();
        builder.AddRam();
        builder.AddVideoCard();
        builder.AddCooler();

        Computer computer = builder.GetComputer();

        computer.ShowInfo();
        
        Console.WriteLine("It works? {0}", computer.ItWorks);
        Console.WriteLine("==================================");

        Computer gamerComputer = new GamerComputerBuilder()
            .AddMotherBoard()
            .AddPowerSupply()
            .AddVideoCard()
            .AddSSD()
            .AddCPU()
            .AddRam()
            .AddRam()
            .GetComputer();
    }
}