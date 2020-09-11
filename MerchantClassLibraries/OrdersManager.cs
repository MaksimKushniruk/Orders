using System;
using System.Collections.Generic;
using System.Text;

namespace MerchantClassLibraries
{
    public class OrdersManager
    {
        public static Order[] GenerateOrders()
        {
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
            return orders;
        }
    }
}
