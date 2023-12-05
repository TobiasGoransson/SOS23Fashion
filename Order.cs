using System;
using System.Collections.Generic;
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
    }
}
