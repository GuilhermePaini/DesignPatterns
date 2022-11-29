namespace Builder;

public interface IGamerComputerBuilder
{
    IGamerComputerBuilder AddVideoCard();
    IGamerComputerBuilder AddCPU();
    IGamerComputerBuilder AddRam();
    IGamerComputerBuilder AddWaterCooler();
    IGamerComputerBuilder AddPowerSupply();
    IGamerComputerBuilder AddMotherBoard();
    IGamerComputerBuilder AddComputerCase();
    IGamerComputerBuilder AddSSD();
    Computer GetComputer();
}
