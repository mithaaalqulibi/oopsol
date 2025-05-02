using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    internal class product
    {
        public string name {  get; set; }
        public double price {  get; set; }
        public int quantity {  get; set; }
         public product (string name, double price, int quantity)
        {
            this.name = name;   
            this.price = price;
            this.quantity = quantity;
        }

        public double totalcost()
        {
            return price * quantity;

        }
        public double totalcost(double price, int quantity)
        {
            return price * quantity;
        }




    }
}
