using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class ObserverExample
    {
        public static void Run()
        {
            CoffeeMachine machine = new CoffeeMachine();
            machine.RegisterObserver(new Printer());
            machine.PrepareCoffee();
            machine.Consume();
            machine.Consume();
            machine.Consume();
            machine.Consume();
        }
    }
}
