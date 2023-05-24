using FasadaDomaci;
using LanacOdgovornostiPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Repositories
{
    public class MaterijalRepository
    {
        public void Add(string naziv, int kursId, string nastavnikJMBG, string url, TipMaterijala tip)
        {
            DB.materijali.Add(new Materijal(naziv, kursId, nastavnikJMBG, url, tip));
        }
    }
}
