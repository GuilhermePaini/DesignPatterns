namespace Observer
{
    internal interface IObserver
    {
        void Updated(ISubject subject);
    }
}
