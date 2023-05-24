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
    // Ovaj handler proverava da li nastavnik predaje na kursu na kojem dodaje materijal
    public class PristupKursuHandler : Handler
    {
        public override void HandleRequest(NoviMaterijalRequest request)
        {
            Kurs kurs = KursRepository.GetById(request.KursId);
            if (kurs.ProfesorJmbg != request.NastavnikJMBG && kurs.AsistentJmbg != request.NastavnikJMBG)
            {
                Console.WriteLine("Nastavnik ne predaje na kursu");
                return;
            }

            nextHandler?.HandleRequest(request);
        }
    }
}
