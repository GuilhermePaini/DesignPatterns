namespace Builder;

public class Computer
{
    public string? VideoCard;
    public string? CPU;
    public string? Cooler;
    public string? WaterCooler;
    public string? PowerSupply;
    public string? MotherBoard;
    public string? ComputerCase;
    public string? HD;
    public List<string> Rams = new List<string>();

    public bool ItWorks {
        get => MotherBoard != null 
            && CPU != null 
            && PowerSupply != null 
            && (Cooler != null || WaterCooler != null) 
            && HD != null
            && Rams?.Count > 0;
    }

    public override string? ToString()
    {
        return base.ToString();
    }

    public void ShowInfo() {
        Console.WriteLine("VideoCard: {0}", VideoCard);
        Console.WriteLine("CPU: {0}", CPU);
        Console.WriteLine("Cooler: {0}", Cooler);
        Console.WriteLine("WaterCooler: {0}", WaterCooler);
        Console.WriteLine("PowerSupply: {0}", PowerSupply);
        Console.WriteLine("MotherBoard: {0}", MotherBoard);
        Console.WriteLine("ComputerCase: {0}", ComputerCase);
        Console.WriteLine("Rams: ");
        
        foreach (var ram in Rams)
        {
            Console.WriteLine("\tMemory: {0}", ram);
        }
    }
}
