namespace Decorator;

public abstract class DogDecorator : IDog
{
    private IDog _dog;

    public DogDecorator(IDog dog) 
    {
        _dog = dog;
    }

    public string Name { get => _dog.Name; }

    public string Breed { get => _dog.Breed; }

    public string FurColor { get => _dog.FurColor; }

    public string Bark() => _dog.Bark();
}
