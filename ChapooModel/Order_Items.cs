using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public enum Order_Status {Besteld, Gereed, Gereserveerd }
    public class Order_Items
    {
        public int Order_Item_ID { get; set; }
        public int Order_ID { get; set; }
        public int Menu_Item_ID { get; set; }
        public int MyProperty { get; set; }
        public Order_Status status { get; set; }
        public int Hoeveelheid { get; set; }
        public DateTime Tijd { get; set; }
        public string Opmerking { get; set; }
    }
}
