using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MerchantClassLibraries
{
    public class OrdersManager
    {
        public static List<Order> GenerateOrders(int quantity)
        {
            List<Order> orders = new List<Order>();
            Random rnd = new Random();
            int year;
            int month;
            int day;

            for (int i = 0; i <= quantity; i++)
            {
                decimal generatedPrice = (decimal)rnd.Next(0, 10000000) / 100;
                year = rnd.Next(2010, 2021);
                month = rnd.Next(1, 13);

                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    day = rnd.Next(1, 32);
                }
                else if (month != 2)
                {
                    day = rnd.Next(1, 31);
                }
                else if (year % 4 == 0)
                {
                    day = rnd.Next(1, 30);
                }
                else
                {
                    day = rnd.Next(1, 29);
                }
                
                DateTime generatedDate = new DateTime(year, month, day, rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60));
                
                orders.Add(new Order(i, generatedPrice, generatedDate, (Status)rnd.Next(0, 3)));
            }

            return orders;
        }
    }
}
