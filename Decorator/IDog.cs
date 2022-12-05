namespace Decorator;

public interface IDog
{
    string Name { get; }
    string Breed { get; }
    string FurColor { get; }
    string Bark();
}
