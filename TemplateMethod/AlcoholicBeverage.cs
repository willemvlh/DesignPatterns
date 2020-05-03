using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public abstract class AlcoholicBeverage
    {
        public AlcoholicBeverage(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public void Serve()
        {
            TakeBottle();
            Glass glass = TakeGlass();
            Pour(glass);
            AddExtra();
            Hand();
        }


        private void Hand()
        {
            Console.WriteLine($"Here you go! A tasty {Name}");
        }


        private void Pour(Glass glass)
        {
            Console.WriteLine($"Pouring into a {glass.GetType().Name}.");
        }


        private void TakeBottle()
        {
            Console.WriteLine("Take bottle");
        }
        internal abstract Glass TakeGlass();
        internal abstract void AddExtra();

    }

    public class Beer : AlcoholicBeverage
    {
        public Beer(string name) : base(name)
        {
        }

        internal override void AddExtra()
        {
            Console.WriteLine("Adding some chips!");
        }

        internal override Glass TakeGlass()
        {
            return new BeerGlass();
        }
    }

    public class Whiskey : AlcoholicBeverage
    {
        public Whiskey(string name) : base(name)
        {
        }

        internal override void AddExtra()
        {
            Console.WriteLine("Adding a tasty cigar...");
        }

        internal override Glass TakeGlass()
        {
            return new WhiskeyGlass();
        }
    }

    public abstract class Glass{}
    public class BeerGlass : Glass { }
    public class WhiskeyGlass : Glass { }
}
