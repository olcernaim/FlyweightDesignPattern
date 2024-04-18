using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public interface IFont
    {
        void SetSize(int size);
        void SetStyle(string style);
        void SetColor(string color);
        void Display(string text);
    }
}
