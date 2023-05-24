using FasadaDomaci.Models;
using LanacOdgovornostiPattern.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Handlers
{
    // Ovaj handler proverava da li su podaci validni
    public class ValidacijaHandler : Handler
    {
        public override void HandleRequest(NoviMaterijalRequest request)
        {
            if (request.Naziv == null || request.Naziv.Length < 3 || request.Url == null)
            {
                Console.WriteLine("Podaci nisu validni");
                return;
            }

            nextHandler?.HandleRequest(request);
        }
    }
}
