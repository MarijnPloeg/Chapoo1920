using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public enum Functie { Eigenaar, Kok, Barman, Ober}
    public class Werknemers
    {
        public int Werknemer_ID { get; set; }
        public string Naam { get; set; }
        public Functie Functie { get; set; }
        public string Wachtwoord { get; set; }

    }
}
