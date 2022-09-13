using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Demo2CodeFirst.Entity
{
    internal class Dbdemo2:DbContext
    {

        public Dbdemo2():base("name=BookDb")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
