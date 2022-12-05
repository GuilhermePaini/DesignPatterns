using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject : ISubject
    {
        public int State { get; set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: attached an observer.");
            _observers.Add(observer);
        }

        public void Attach(List<IObserver> observers)
        {
            Console.WriteLine($"Subject: attached {observers.Count} observers.");
            _observers.AddRange(observers);
        }

        public void Dettach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer.");
            _observers.Remove(observer);
        }
        public void Dettach(List<IObserver> observers)
        {
            Console.WriteLine("Subject: Detached an observer.");

            foreach (var observer in observers)
                _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Updated(this);
            }
        }

        public void DoWork()
        {
            Console.WriteLine("\nSubject: Something important is happening...");
            State = new Random().Next(0, 10); 
            Thread.Sleep(15); 
            Console.WriteLine("Subject: My state has just changed to: " + State);
            Notify();
        }
    }
}
