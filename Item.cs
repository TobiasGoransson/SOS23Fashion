﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSFashion
{
    internal class Item
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int SoldTotal { get; set; }
        public string Category { get; set; }


        public Item(string itemName, int price, int quantity, string size, string color, int soldTotal, string category)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
            Size = size;
            Color = color;
            SoldTotal = soldTotal;
            Category = category;
        }
        public Item(string itemName, int price, int quantity, string size, string color, string category)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
            Size = size;
            Color = color;
            Category = category;
            SoldTotal = 0;

        }
        public string GetCSV()
        {
            return ItemName + ";" + Price + ";" + Quantity + ";" + Size + ";" + Color + ";" + SoldTotal + ";" + Category;
        }
        
    }
}
