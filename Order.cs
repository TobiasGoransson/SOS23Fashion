﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSFashion
{
    internal class Order
    {
        public int OrderNo { get; set; }
        public string Username { get; set; }
        public DateTime Placedtime  { get; set; }
        List<Item> Items { get; set; }

        public Order(int orderNo, string username, DateTime placedtime)
        {
            OrderNo = orderNo;
            Username = username;
            Placedtime = placedtime;
            
        }

        public Order(string username, List<Item> items)
        {
            Username = username;
            Items = items;
        }
        public string GetOrderCSV()
        {
            return OrderNo + ";" + Username + ";" + Placedtime;
        }

      
    }
}
