namespace Decorator;

public class Pinscher : IDog
{
    public string Name { get => "Marcelin"; }

    public string Breed { get => "Pinscher"; }

    public string FurColor { get => "Brown" ;}

    public string Bark() => $"{Name} said: rrrrrraaaaurfff";
}
