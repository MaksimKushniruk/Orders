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

        public void DisplayOrderInfoById()
        {
            Console.WriteLine($"Заказ №{id}\n ID: {id}\n Цена: {price}\n Дата заказа: {date}\n Статус заказа: {status}");
            Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine($"ID: {id}\t Цена: {price}\t Дата заказа: {date}\t Статус заказа: {status}");
        }
    }
}
