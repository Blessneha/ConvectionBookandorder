using Demo2CodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Repositories
{
    internal class OrderRepository
    {

        public Dbdemo2 d = new Dbdemo2();

        public void PlaceOrder(Order o)
        {
            d.Orders.Add(o);
            d.SaveChanges();
        }
    }
}
