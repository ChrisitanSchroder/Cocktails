using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cocktails
{
    class DrinkContext : DbContext
    {
        public DrinkContext() : base("DrinkDB")
        {

        }
        public DbSet<Drink> Drinks { get; set; }
        
    }
}
