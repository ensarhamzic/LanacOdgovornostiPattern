using FasadaDomaci.Models;
using LanacOdgovornostiPattern.Models;
using LanacOdgovornostiPattern.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Handlers
{
    // Ovaj handler cuva materijal u bazu ako svi prosli handleri nisu prekinuli lanac
    public class CuvanjeMaterijalaHandler : Handler
    {
        public override void HandleRequest(NoviMaterijalRequest request)
        {
            Nastavnik nastavnik = NastavnikRepository.GetByJMBG(request.NastavnikJMBG);
            TipMaterijala tip = TipMaterijala.PREDAVANJA;
            if(nastavnik.Tip == TipNastavnika.ASISTENT)
                tip = TipMaterijala.VEZBE;
            MaterijalRepository.Add(request.Naziv, request.KursId, request.NastavnikJMBG, request.Url, tip);
            Console.WriteLine("Materijal uspesno dodat!");

            nextHandler?.HandleRequest(request);
        }
    }
}
