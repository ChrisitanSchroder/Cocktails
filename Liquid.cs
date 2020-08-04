using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Liquid : Ingridient
    {
        public string Color { get; private set; }
        string name;
        public bool Alcohol { get; private set; }
        public Liquid(string color, bool alcohol)
        {
            Color = color;
            Alcohol = alcohol;
        }
    }
}
