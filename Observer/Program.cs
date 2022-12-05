using Observer;

internal class Program
{
    private static void Main(string[] args)
    {
        var subject = new Subject();
        var observer = new ConcreteObserver();
        var anotherObserver = new AnotherConcreteObserver();

        subject.Attach(new List<IObserver> { observer, anotherObserver });

        subject.DoWork();
        subject.DoWork();

        subject.Dettach(anotherObserver);
        subject.DoWork();
    }
}