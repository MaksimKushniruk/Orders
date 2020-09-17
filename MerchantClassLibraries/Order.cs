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
        public int id;
        public double price;
        public DateTime date;
        public Status status;

        public Order(int id, double price, DateTime date, Status status)
        {
            this.id = id;
            this.price = price;
            this.date = date;
            this.status = status;
        }

        public string GetOrderInfoById()
        {
            string orderInfoById = "Заказ №" + id + " ID: " + id + " Цена: " + price + " Дата заказа: " + date + " Статус заказа: " + status;
            return orderInfoById;
        }
    }
}
