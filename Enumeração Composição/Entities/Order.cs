using System;
using System.Text;
using System.Collections.Generic;
using Enumeração_Composição.Entities.Enums;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Enumeração_Composição.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
       
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() 
        { 
        }  
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;   
            Client = client;

        }

        public void AddItem(OrderItem item) 
        {
            Items.Add(item);  
        }
        public void RemoveItem(OrderItem item) 
        {
            Items.Remove(item);
        }

        
    }
}
