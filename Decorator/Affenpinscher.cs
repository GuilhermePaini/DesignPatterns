namespace Decorator;

public class Affenpinscher : DogDecorator
{
    public Affenpinscher(IDog dog) : base(dog) {}
    public string Bark() => "Affenpinscher said: rrrrreeef";
}
