using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Afrekenen
    {
        public int selectie_hoeveelheid { get; set; }
        public int selectie_hoeveelheid_prijs { get; set; }
        public string selectie_Opmerking { get; set; }
        public double BTW_percentage { get; set; }
        public double fooi { get; set; }
        public double TotaalPrijs { get; set; }
        public int menuItemID { get; set; }
    }
}
