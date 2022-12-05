namespace Decorator;

public class Affenpinscher : DogDecorator
{
    public Affenpinscher(IDog dog) : base(dog) {}
    public string Breed { get => "Affenpinscher"; }
    public string FurColor { get => "Totally black"; }
    public string Bark() => "Affenpinscher said: rrrrreeef";
}
