using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface IObserver
    {
        public void Update(string s);
    }

    public class Printer : IObserver
    {
        public void Update(string s)
        {
            Console.WriteLine($"----{s}----");
        }
    }

    public class Shoutbox : IObserver
    {
        public void Update(string s)
        {
            Console.WriteLine($"!!!!! {s} !!!!!");
        }
    }
}
