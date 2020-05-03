using DesignPatterns.Models;
using System;

namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractDocumentFactory
    {
        public abstract Document CreateDocument();
    }

    public class OfficialDocumentFactory : AbstractDocumentFactory
    {
        public override Document CreateDocument()
        {
            return new OfficialDocument() {
                SampleText = "Official"
            };
        }
    }

    public class BlueOfficialDocumentFactory : AbstractDocumentFactory
    {
        public override Document CreateDocument()
        {
            return new OfficialDocument
            {
                BackgroundColor = ConsoleColor.Blue
            };
        }
    }

    public class WeirdDocumentFactory : AbstractDocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WeirdDocument();
        }
    }

}
