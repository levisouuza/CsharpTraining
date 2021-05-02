using EnumComposicoes.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System;


namespace EnumComposicoes.Entities
{
    class Order
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

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem itens in Items)
            {
                sum += itens.Price;
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nORDER SUMMARY:");
            sb.Append("Order momento: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append("(" + Client.BirthDate.ToString("dd/MM/yyyy") + ") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order Itens: ");
            
            foreach(OrderItem itens in Items)
            {
                sb.Append(itens.Product.Name);
                sb.Append(", ");
                sb.Append(itens.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(itens.Quantity);
                sb.Append(", Subtotal: ");
                sb.AppendLine(itens.SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            }
            sb.Append("Total price: ");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
          
            return sb.ToString();
        }

    }
}
