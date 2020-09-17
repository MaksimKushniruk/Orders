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



        static void GetOrderInfoById(Order[] orders)
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
                        Console.Clear();
                        Console.WriteLine(orders[0].GetOrderInfoById());
                        Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        return;
                    case 2:
                        Console.Clear();
                        orders[1].GetOrderInfoById();
                        Console.WriteLine(orders[1].GetOrderInfoById());
                        Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        return;
                    case 3:
                        Console.Clear();
                        orders[2].GetOrderInfoById();
                        Console.WriteLine(orders[2].GetOrderInfoById());
                        Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        return;
                    case 4:
                        Console.Clear();
                        orders[3].GetOrderInfoById();
                        Console.WriteLine(orders[3].GetOrderInfoById());
                        Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        return;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(orders[4].GetOrderInfoById());
                        orders[4].GetOrderInfoById();
                        Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Такого ID не существует, нажмите любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }

        static void DisplayAllOrdersInfo(Order[] orders)
        {
            Console.Clear();
            for (int i = 0; i < orders.Length; i++)
            {
                Console.WriteLine(orders[i].GetOrderInfoById());
            }
            Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
