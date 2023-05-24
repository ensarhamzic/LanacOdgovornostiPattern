using FasadaDomaci.Models;
using LanacOdgovornostiPattern.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Handlers
{
    // Ovaj handler proverava da li kurs postoji u bazi
    public class ProveraKursaHandler : Handler
    {
        public override void HandleRequest(NoviMaterijalRequest request)
        {
            Kurs kurs = KursRepository.GetById(request.KursId);
            if (kurs == null)
            {
                Console.WriteLine("Kurs ne postoji");
                return;
            }
               
            nextHandler?.HandleRequest(request);
        }
    }
}
