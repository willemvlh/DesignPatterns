using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class TemplateMethodExample
    {
        public static void Run()
        {
            Beer b = new Beer("Duvel");
            b.Serve();

            Whiskey w = new Whiskey("Johnny Walker");
            w.Serve();
        }
    }
}
