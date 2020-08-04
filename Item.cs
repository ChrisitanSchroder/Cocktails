using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Item
    {
        public int Amount { get; private set; }
        public Ingridient Ingridient { get; private set; }
        public Item(int amount, Ingridient ingridient)
        {
            Ingridient = ingridient;
            Amount = amount;
        }
    }
}
