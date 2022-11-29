namespace Builder;

public class GamerComputerBuilder : IGamerComputerBuilder
{
    Computer computer = new Computer();

    public IGamerComputerBuilder AddComputerCase()
    {
        computer.ComputerCase = "tower with rgb";
        return this;
    }

    public IGamerComputerBuilder AddCPU()
    {
        computer.CPU = "intel i7 11000HQ lake 4.6ghz";
        return this;
    }

    public IGamerComputerBuilder AddSSD()
    {
        computer.HD = "SDD 1TB 2500mbs";
        return this;
    }

    public IGamerComputerBuilder AddMotherBoard()
    {
        computer.MotherBoard = "Some gaming motherboard :)";
        return this;
    }

    public IGamerComputerBuilder AddPowerSupply()
    {
        computer.MotherBoard = "ultra gamer power supply with rgb";
        return this;
    }

    public IGamerComputerBuilder AddRam()
    {
        if(computer.Rams?.Count >= 4)
            throw new Exception("Not enough slots for this :(");

        computer.Rams?.Add("16gb DDR5 with rgb");
        return this;
    }

    public IGamerComputerBuilder AddVideoCard()
    {
        computer.VideoCard = "RTX 4090ti with rgb";
        return this;
    }

    public IGamerComputerBuilder AddWaterCooler()
    {
        computer.WaterCooler = "watercooler with rgb";
        return this;
    }

    public Computer GetComputer()
    {
        if(!computer.ItWorks)
            throw new Exception("This GAMER PC will not work :((((");

        return computer;
    }
}
