using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class FontFactory
    {
        private Dictionary<string, IFont> fonts = new Dictionary<string, IFont>();
        public IFont GetFont(string key)
        {
            if (!fonts.ContainsKey(key))
            {
                fonts[key] = new ConcreteFont();
            }

            return fonts[key];
        }
    }
}
