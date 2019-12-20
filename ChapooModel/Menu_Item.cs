using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Menu_Item
    {
        public int Menu_ID { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int Voorraad { get; set; }
        public int Categorie_ID { get; set; }
    }
}
