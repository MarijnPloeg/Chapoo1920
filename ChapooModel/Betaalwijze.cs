using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public enum BetaalMethode { contant, pin }
    public class Betaalwijze
    {
        public int Betaal_ID { get; set; }
        public int Order_ID { get; set; }
        public BetaalMethode BetaalMethode { get; set; }
        public float TotaalPrijs { get; set; }
        public int Fooi { get; set; }
    }
}
