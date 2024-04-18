using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class ConcreteFont : IFont
    {
        private int _size;
        private string _style;
        private string _color;
        public void Display(string text)
        {
            Console.WriteLine($"Text: '{text}' | Size: '{_size}' | Style: '{_style}' | Color: '{_color}' |");
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void SetSize(int size)
        {
            _size = size;
        }

        public void SetStyle(string style)
        {
            _style = style;
        }
    }
}
