using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Orders
{
    enum Status
    {
        Обрабатывается,
        Оплачен,
        Доставлен
    }
    class Orders
    {
        public int id;
        public double price;
        public DateTime date;
        public Status st;

        public Orders(int id, double price, DateTime date, Status st)
        {
            this.id = id;
            this.price = price;
            this.date = date;
            this.st = st;
        }

        public void GetOrdersInfo()
        {
            Console.Clear();
            Console.WriteLine($"Заказ №{id}\n ID: {id}\n Цена: {price}\n Дата заказа: {date}\n Статус заказа: {st}");
            Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
            Console.ReadKey();
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"ID: {id}\t Цена: {price}\t Дата заказа: {date}\t Статус заказа: {st}");
        }
    }
}
