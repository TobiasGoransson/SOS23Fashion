using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOSFashion
{
    public class ItemManager
    {
        string itemsFilePath = "Items/Items.csv";
        List<Item> items = new List<Item>();

        public List<Item> GetItemList()
        {
            using (StreamReader reader = new StreamReader(itemsFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        string[] strings = line.Split(";");
                        string name = strings[0];
                        int price = Convert.ToInt32(strings[1]);
                        int amountStock = Convert.ToInt32(strings[2]);
                        string size = strings[3];
                        string color = strings[4];
                        int amountSold = Convert.ToInt32(strings[5]);
                        string category = strings[6];

                        items.Add(new Item(name, price, amountStock, size, color, amountSold, category));
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return items;
        }
        public void RegisterNewItem( Item item)
        {
                using (StreamWriter sw = File.AppendText(itemsFilePath))
                {
                    sw.WriteLine(item.GetCSV());
                }
        }
    }
}
