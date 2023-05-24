using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Models
{
    public class Materijal
    {
        public static int IdCounter = 0;
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int KursId { get; set; }
        public string NastavnikJMBG { get; set; }
        public string Url { get; set; }
        public TipMaterijala Tip { get; set; }

        public Materijal(string naziv, int kursId, string nastavnikJMBG, string url, TipMaterijala tip)
        {
            Id = ++IdCounter;
            Naziv = naziv;
            KursId = kursId;
            NastavnikJMBG = nastavnikJMBG;
            Url = url;
            Tip = tip;
        }

        public override string ToString()
        {
            return $"{Id}: {Naziv}";
        }
    }
}
