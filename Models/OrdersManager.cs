using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repair_Service.DAL;

namespace Repair_Service.Models
{
    public class OrdersManager
    {
        public List<Order> orders;
        OrdersTable ordersTable;

        public OrdersManager()
        {
            orders = new List<Order>();
            ordersTable = new OrdersTable();
            GetOrdersFromDB();
        }

        public void AddNewOrder(string mainProblem, string phoneNumber, string ownerName, int startPrice, Type type)
        {
            Order order = new Order(mainProblem, phoneNumber, ownerName, startPrice, DateTime.Now, type, Status.Taken);
            if (ordersTable.InsertData(order))
            {
                orders.Add(order);
            }
        }

        public void GetOrdersFromDB()
        {
            ordersTable.ReadData();
            orders = ordersTable.GetOrders();
        }

        public void UpdateOrder(string mainProblem, string phoneNumber, string ownerName, int startPrice, Status status)
        {

        }

        public List<Order> GetOrders()
        {
            return orders;
        }

    }
}
