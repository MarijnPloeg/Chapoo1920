using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{

    public class Orders
    {
        public int Order_ID { get; set; }
        public int Werknemer_ID { get; set; }
        public int Tafel_ID { get; set; }
        public string Opmerking { get; set; }
        public int Betaald { get; set; }
    }
}
