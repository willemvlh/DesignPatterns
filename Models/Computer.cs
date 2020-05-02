using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Models
{
    public abstract class Computer
    {
        public string Manufacturer { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
    }

    public class Laptop : Computer
    {

    }

    public class DesktopComputer : Computer
    {

    }
}
