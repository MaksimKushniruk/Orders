using System;

namespace Orders
{

    class Program
    {

        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                int choice = 0;

                Status processed = Status.Обрабатывается;
                Status paid = Status.Оплачен;
                Status delivered = Status.Доставлен;

                DateTime date1 = new DateTime(2020, 7, 25, 12, 45, 15);
                DateTime date2 = new DateTime(2020, 7, 17, 10, 30, 49);
                DateTime date3 = new DateTime(2020, 7, 12, 17, 22, 59);
                DateTime date4 = new DateTime(2020, 6, 29, 15, 16, 23);
                DateTime date5 = new DateTime(2020, 6, 25, 14, 50, 36);

                Order[] orders = new Order[5];
                orders[0] = new Order(1, 500.50, date1, processed);
                orders[1] = new Order(2, 346.79, date2, paid);
                orders[2] = new Order(3, 17643.2, date3, delivered);
                orders[3] = new Order(4, 2131.43, date4, delivered);
                orders[4] = new Order(5, 1216.21, date5, delivered);

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
            for(int i = 0; i < orders.Length; i++)
            {
                orders[i].GetFullInfo();
            }
            Console.WriteLine("Чтобы выйти в главное меню нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
