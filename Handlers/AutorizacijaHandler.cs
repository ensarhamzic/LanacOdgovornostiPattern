using FasadaDomaci.Models;
using FasadaDomaci.Repositories;
using LanacOdgovornostiPattern.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Handlers
{
    // Ovaj handler proverava da li zahtev salje nastavnik
    public class AutorizacijaHandler : Handler
    {
        public override void HandleRequest(NoviMaterijalRequest request)
        {
            Nastavnik nastavnik = NastavnikRepository.GetByJMBG(request.NastavnikJMBG);
            if (nastavnik == null)
            {
                Console.WriteLine("Materijal mora biti postavljen od strane nastavnika");
                return;
            }

            nextHandler?.HandleRequest(request);
        }
    }
}
