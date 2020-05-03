using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class DocumentApplication
    {
        public Document CreateDocument(AbstractDocumentFactory factory)
        {
            return factory.CreateDocument();
        }

        public void Run()
        {
            Console.WriteLine("Enter 'a' for an official document, or 'b' for a weird document");
            char character = (char)Console.Read();
            AbstractDocumentFactory factory;
            if(character == 'a')
            {
                factory = new BlueOfficialDocumentFactory();
            }
            else
            {
                factory = new WeirdDocumentFactory();
            }
            Document doc = CreateDocument(factory);
            Console.WriteLine($"Here is a {doc.GetType().Name}");
            doc.PrintToConsole();

        }
    }
}
