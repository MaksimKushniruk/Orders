using System;
using System.Collections.Generic;
using System.Linq;
using MerchantClassLibraries;

namespace MerchantConsoleApplication
{

    class Program
    {

        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                int choice = 0;
                int quantityOrders;
                Console.Write("Введите число заказов: ");

                try
                {
                    quantityOrders = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.ReadKey();
                    continue;
                }
                
                List<Order> orders = OrdersManager.GenerateOrders(quantityOrders);

                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Отобразить информацию про заказ по id");
                Console.WriteLine("2. Вывести информацию о всех заказах");
                Console.WriteLine("3. Выход");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число!");
                }

                switch (choice)
                {
                    case 1:
                        GetOrderInfoById(orders);
                        break;
                    case 2:
                        DisplayAllOrdersInfo(orders);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода, нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }
            }
        }



        static void GetOrderInfoById(List<Order> orders)
        {
            int id = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Введите ID заказа: ");

                try
                {
                    id = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Такого ID не существует, нажмите любую клавишу.");
                    Console.ReadKey();
                }

                if (0 < id && id <= orders.Count)
                {
                    var order = orders.FirstOrDefault(o => o.Id == id);
                    Console.WriteLine(order.GetOrderInfoById());
                    Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Такого ID не существует, нажмите любую клавишу.");
                    Console.ReadKey();
                }
            }
        }

        static void DisplayAllOrdersInfo(List<Order> orders)
        {
            Console.Clear();
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].GetOrderInfoById());
            }
            Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
