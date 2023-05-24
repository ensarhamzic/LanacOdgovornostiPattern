using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Requests
{
    public class NoviMaterijalRequest
    {
        public string Naziv { get; set; }
        public int KursId { get; set; }
        public string NastavnikJMBG { get; set; }
        public string Url { get; set; }
    }
}
