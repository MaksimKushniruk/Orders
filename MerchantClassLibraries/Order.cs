using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MerchantClassLibraries
{
    public enum Status
    {
        Обрабатывается,
        Оплачен,
        Доставлен
    }
    public class Order
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }

        public Order(int id, double price, DateTime date, Status status)
        {
            this.Id = id;
            this.Price = price;
            this.Date = date;
            this.Status = status;
        }

        public string GetOrderInfoById()
        {
            string orderInfoById = "Заказ №" + Id + " ID: " + Id + " Цена: " + Price + " Дата заказа: " + Date + " Статус заказа: " + Status;
            return orderInfoById;
        }
    }
}
