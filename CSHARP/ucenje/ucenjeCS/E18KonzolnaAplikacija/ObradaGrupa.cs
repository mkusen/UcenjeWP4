using UcenjeCS.E18KonzolnaAplikacija.Pomocno;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaGrupa: PomocnoEntitet
    {

        PomocnoObradaGrupa pomocnoObradaGrupa;

        public ObradaGrupa()
        {
            pomocnoObradaGrupa = new PomocnoObradaGrupa();
            
           

        }
      

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama\n" +
                "1.Pregled svih grupa\n" +
                "2.Unos nove grupe\n" +
                "3.Promjena podataka postojeće grupe\n" +
                "4.Brisanje grupe\n" +
                "5.Povratak na glavni izbornik");
                OdabirOpcijeIzbornika();
        }


        public void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.PomocnoObrada.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    pomocnoObradaGrupa.PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    pomocnoObradaGrupa.UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    pomocnoObradaGrupa.PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    pomocnoObradaGrupa.ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }



    }
}
