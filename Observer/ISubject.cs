namespace Observer
{
    internal interface ISubject
    {
        void Attach(IObserver observer);
        void Attach(List<IObserver> observers);
        void Dettach(IObserver observer);
        void Dettach(List<IObserver> observers);
        void Notify();
    }
}
