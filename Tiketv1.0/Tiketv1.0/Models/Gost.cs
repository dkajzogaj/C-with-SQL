using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiketv1._0.Models
{
    public class Gost
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public int OIB { get; set; }
        public string VrstaSmjestaja { get; set; }
        public int BrojOsobaUSmjestaju { get; set; }
        public int PozicijaSmjestaja { get; set; }
    }
}
