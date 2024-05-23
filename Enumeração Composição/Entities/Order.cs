using System;
using System.Text;
using System.Collections.Generic;
using Enumeração_Composição.Entities.Enums;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

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

        public double total ()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();

            }
            return sum;     
        }
        public override string ToString()
        {
            stringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items:");
            foreach (OrderItem item in Items)
            {
            }
            sb.AppendLine(Items.ToString());
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
