using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MerchantClassLibraries
{
    public class OrdersManager
    {
        public static List<Order> GenerateOrders(int a)
        {
            List<Order> orders = new List<Order>();
            for(int i = 0; i <= a; i++)
            {
                Random rnd = new Random(i);
                decimal generatePrice = rnd.Next(0, 100000);
                DateTime generateDate = new DateTime(2020, rnd.Next(1, 12), rnd.Next(1, 30), rnd.Next(0, 23), rnd.Next(0, 59), rnd.Next(0, 59));
                Status generateStatus = (Status)rnd.Next(0, 2);
                orders.Add(new Order(i, generatePrice, generateDate, generateStatus));
            }

            return orders;
        }
    }
}
