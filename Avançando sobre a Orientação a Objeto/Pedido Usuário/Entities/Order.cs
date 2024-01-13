using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Course.Entities.Enum;

namespace Course.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        
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
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItem)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("G"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("d") + ") - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
