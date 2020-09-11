using System;
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

                Order[] orders = OrdersManager.GenerateOrders();

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
                    // Console.WriteLine("Вы ввели не число!");
                }

                switch (choice)
                {
                    case 1:
                        OrderId(orders);
                        break;
                    case 2:
                        OrderFullInfo(orders);
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



        static void OrderId(Order[] orders)
        {
            int id;

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
                    Console.Clear();
                    continue;
                }

                switch (id)
                {
                    case 1:
                        orders[0].GetOrdersInfo();
                        return;
                    case 2:
                        orders[1].GetOrdersInfo();
                        return;
                    case 3:
                        orders[2].GetOrdersInfo();
                        return;
                    case 4:
                        orders[3].GetOrdersInfo();
                        return;
                    case 5:
                        orders[4].GetOrdersInfo();
                        return;
                    default:
                        Console.WriteLine("Такого ID не существует, нажмите любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }

        static void OrderFullInfo(Order[] orders)
        {
            Console.Clear();
            for (int i = 0; i < orders.Length; i++)
            {
                orders[i].GetFullInfo();
            }
            Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
