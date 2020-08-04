using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Drink
    {
        public string Name { get; private set; }
        public List<Item> Items { get; private set; }
        public Drink(string name, List<Item> items)
        {
            Items = items;
            Name = name;
        }
    }
}
