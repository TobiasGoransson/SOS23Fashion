using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SOSFashion
{
    internal class OrderManager
    {
        public string OrderFilePath;

        public List<Order> GetOrders(string UserName)
        {
            OrderFilePath = "OrderLists/" + UserName + ".csv";
            List<Order> orders = new List<Order>();
            using (StreamReader sr = new StreamReader(OrderFilePath))
            {

                string nextLine = sr.ReadLine();
                while (nextLine != null)
                {
                    string[] variables = nextLine.Split(';');
                    int orderNo = int.Parse(variables[0]);
                    DateTime date = DateTime.Parse(variables[2]);

                    Order order = new Order(orderNo, variables[1], date);
                    orders.Add(order);

                    nextLine = sr.ReadLine();
                }

            }
            return orders;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> allOrders = GetOrders("AllOrders");
            return allOrders;
        }

        public int CreateNewOrder(User user)
        {
            List<Order> allOrders = GetAllOrders();
            int newOrderNumber = 0;
            for (int i = 0; i < allOrders.Count; i++)
            {
                if (allOrders[i] == allOrders.Last())
                {
                    newOrderNumber = allOrders[i].OrderNo;
                    newOrderNumber++;
                }
            }

            Order newOrder = new Order(newOrderNumber, user.UserName, DateTime.Now);
            allOrders.Add(newOrder);
            RegisterNewOrder(newOrder, "AllOrders");


            List<Order> accounts = new List<Order>();
            allOrders.Add(newOrder);
            RegisterNewOrder(newOrder, user.UserName);

            return newOrderNumber;
        }

        public void RegisterNewOrder(Order order, string UserName)
        {
            OrderFilePath = "UserAccounts/" + UserName + ".csv";

            using (StreamWriter sw = File.AppendText(OrderFilePath))
            {
                sw.WriteLine(order.GetOrderCSV());
            }

        }
    }
}
