using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public enum Tafel_Status { Open, Gereserveerd, Bezet}
    public class Tafel
    {
        public int Tafel_ID { get; set; }
        public Tafel_Status Tafel_Status { get; set; }
        public int Aantal_Personen { get; set; }
    }
}
