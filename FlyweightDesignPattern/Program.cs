using System;

namespace FlyweightDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FontFactory fontFactory = new FontFactory();

            IFont font1 = fontFactory.GetFont("Arial");
            IFont font2 = fontFactory.GetFont("Times New Roman");
            IFont font3 = fontFactory.GetFont("Arial");
            IFont font4 = fontFactory.GetFont("Calibri");

            font1.SetSize(12);
            font1.SetStyle("Regular");
            font1.SetColor("Black");

            font2.SetSize(14);
            font2.SetStyle("Italic");
            font2.SetColor("Red");

            font1.Display("Font1");
            font2.Display("Font2");

            //Console.WriteLine("Hello World!");
        }
    }
}
