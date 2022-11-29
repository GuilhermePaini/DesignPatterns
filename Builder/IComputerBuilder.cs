namespace Builder;

public interface IComputerBuilder
{
    void AddVideoCard();
    void AddCPU();
    void AddRam();
    void AddCooler();
    void AddWaterCooler();
    void AddPowerSupply();
    void AddMotherBoard();
    void AddComputerCase();
    void AddHD();
    Computer GetComputer();
}
