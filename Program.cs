using FasadaDomaci;
using FasadaDomaci.Models;
using FasadaDomaci.Repositories;
using LanacOdgovornostiPattern.Handlers;
using LanacOdgovornostiPattern.Requests;

NastavnikRepository nastavnikRepository = new NastavnikRepository();
KursRepository kursRepository = new KursRepository();
SmerRepository smerRepository = new SmerRepository();

Nastavnik profesor = new Nastavnik("1234567891234", "Profesor", "Profesor", "Docent", TipNastavnika.PROFESOR);
Nastavnik profesor2 = new Nastavnik("1234567891244", "Profesor", "Profesor", "Docent", TipNastavnika.PROFESOR);
Nastavnik asistent = new Nastavnik("1234567891235", "Asistent", "Asistent", "Asistent", TipNastavnika.ASISTENT);
Smer smer = new Smer("Softversko inzenjerstvo", "SI");
Kurs kurs = new Kurs("Informacioni sistemi", smer.Id, profesor.JMBG, asistent.JMBG);

nastavnikRepository.Add(profesor);
nastavnikRepository.Add(profesor2);
nastavnikRepository.Add(asistent);
smerRepository.Add(smer);
kursRepository.Add(kurs);

var podaci = new NoviMaterijalRequest
{
    Naziv = "Prvo predavanje",
    KursId = kurs.Id,
    NastavnikJMBG = profesor.JMBG,
    Url = "http://www.materijal1.com"
};

AutorizacijaHandler autorizacijaHandler = new AutorizacijaHandler(); // NastavnikJMBG mora biti JMBG nekog od nastavnika
ProveraKursaHandler proveraKursaHandler = new ProveraKursaHandler(); // KursId mora biti ID nekog od kurseva
PristupKursuHandler pristupKursuHandler = new PristupKursuHandler(); // NastavnikJMBG mora biti JMBG profesora ili asistenta na kursu
ValidacijaHandler validacijaHandler = new ValidacijaHandler(); // Naziv i Url ne smeju biti prazni
CuvanjeMaterijalaHandler cuvanjeMaterijalaHandler = new CuvanjeMaterijalaHandler(); // Materijal se cuva u bazu

autorizacijaHandler.SetNextHandler(proveraKursaHandler);
proveraKursaHandler.SetNextHandler(pristupKursuHandler);
pristupKursuHandler.SetNextHandler(validacijaHandler);
validacijaHandler.SetNextHandler(cuvanjeMaterijalaHandler);
autorizacijaHandler.HandleRequest(podaci);
