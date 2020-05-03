using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Models
{
    public abstract class Document
    {
        public string Font { get; set; }
        public int Margin { get; set; }
        public ConsoleColor FontColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public string SampleText { get; set; } = "Lorem ipsum";
        public int LineWidth { get; set; } = 18;
        public int Lines { get; set; } = 8;

        public void PrintToConsole()
        {
            int _lineWidth = LineWidth;
            int _lines = Lines;
            var _bgColor = Console.BackgroundColor;
            var _fgColor = Console.ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = FontColor;
            Console.WriteLine(" ".PadLeft(_lineWidth));
            int spaces = _lineWidth - SampleText.Length;
            Console.WriteLine(SampleText.PadLeft(spaces / 2 + SampleText.Length).PadRight(_lineWidth));
            foreach (int _ in Enumerable.Range(1, _lines - 2))
            {
                Console.WriteLine("".PadLeft(_lineWidth));
            }
            Console.BackgroundColor = _bgColor;
            Console.ForegroundColor = _fgColor;

        }
    }

    public class OfficialDocument : Document
    {
        public OfficialDocument()
        {
            Font = "Times New Roman";
            Margin = 2;
            FontColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
        }
    }

    public class WeirdDocument : Document
    {
        public WeirdDocument()
        {
            Font = "Comic Sans";
            Margin = 0;
            FontColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.Blue;
            SampleText = "YAAAA";
            Lines = 50;
            LineWidth = 10;
        }
    }

    public class CustomDocument : Document { }
}
