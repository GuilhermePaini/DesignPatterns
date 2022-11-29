namespace Builder;

public class ComputerBuilder : IComputerBuilder
{
    Computer computer = new Computer();

    public void AddComputerCase()
    {
        computer.ComputerCase = "Mini ITX";
    }

    public void AddCooler()
    {
        if(computer.WaterCooler != null)
            throw new Exception("This computer already have a water cooler");
        
        computer.Cooler = "Hyper";
    }

    public void AddCPU()
    {
        computer.CPU = "AMD Ryzen 7";
    }

    public void AddHD()
    {
        computer.HD = "1 TB";
    }

    public void AddMotherBoard()
    {
        computer.MotherBoard = "Gigabyte DDR5";
    }

    public void AddPowerSupply()
    {
        computer.PowerSupply = "800w 80plus golden";
    }

    public void AddRam()
    {
        if(computer.Rams?.Count >= 4)
            throw new Exception("Not enough slots for this :(");

        computer.Rams?.Add("8gb DDR5");
    }

    public void AddVideoCard()
    {
        computer.VideoCard = "GTX 2060 8gb GDDR5";
    }

    public void AddWaterCooler()
    {
        if(computer.Cooler != null)
            throw new Exception("This computer already have a water cooler");

        computer.WaterCooler = "Rise mode frost";
    }

    public Computer GetComputer() {
        if(!computer.ItWorks)
            throw new Exception("This PC will not work :((((");
        
        return computer;
    }
}
