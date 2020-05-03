using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.Observer
{
    public class CoffeeMachine : IObservable
    {
        private IList<IObserver> _observers = new List<IObserver>();
        private int _availableCups = 0;
        public void PrepareCoffee()
        {
            Console.WriteLine("Making some coffee...");
            _availableCups = _availableCups + 3;
            Notify($"Coffee is ready! I've got {_availableCups} cup{(_availableCups > 1? "s" : "")}.");
        }

        public void Consume()
        {
            if(_availableCups > 0)
            {
                _availableCups--;
                Console.WriteLine("Enjoy!");
                Notify($"Available cups left: {_availableCups}");
            }
            else
            {
                Console.Error.WriteLine("Error: no coffee left! Please prepare some");
            }
        }

        public void Notify(string s)
        {
            foreach(var observer in _observers)
            {
                observer.Update(s);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
