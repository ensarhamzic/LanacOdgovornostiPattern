using FasadaDomaci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDomaci.Repositories
{
    public class NastavnikRepository
    {
        public Nastavnik GetByJMBG(string jmbg)
        {
            return DB.nastavnici.Where(x => x.JMBG == jmbg).FirstOrDefault();
        }

        public Nastavnik GetProfesorByJMBG(string jmbg)
        {
            return DB.nastavnici.Where(x => x.JMBG == jmbg && x.Tip == TipNastavnika.PROFESOR).FirstOrDefault();
        }

        public Nastavnik GetAsistentByJMBG(string jmbg)
        {
            return DB.nastavnici.Where(x => x.JMBG == jmbg && x.Tip == TipNastavnika.ASISTENT).FirstOrDefault();
        }

        public List<Nastavnik> GetAll()
        {
            return DB.nastavnici;
        }

        public void Add(Nastavnik nastavnik)
        {
            DB.nastavnici.Add(nastavnik);
        }

    }
}
