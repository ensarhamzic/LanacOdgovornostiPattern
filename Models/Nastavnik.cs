using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDomaci.Models
{
    public class Nastavnik : Osoba
    {
        public string Zvanje { get; set; }
        public TipNastavnika Tip { get; set; }

        public Nastavnik(string jmbg, string ime, string prezime, string zvanje, TipNastavnika tip) : base(jmbg, ime, prezime)
        {
            Zvanje = zvanje;
            Tip = tip;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime} {JMBG} {Zvanje} {Tip}";
        }
    }
}
