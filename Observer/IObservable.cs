using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    interface IObservable
    {
        public void Notify(string s);
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);

    }
}
