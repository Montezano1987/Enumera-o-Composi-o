using System;
using System.Text;

namespace Enumeração_Composição.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() 
        { 
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        { 
            return Quantity * Price;    
        }
    }
}
