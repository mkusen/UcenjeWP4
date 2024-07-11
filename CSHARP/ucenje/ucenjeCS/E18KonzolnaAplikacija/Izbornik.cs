using UcenjeCS.E18KonzolnaAplikacija.Pomocno;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class Izbornik:PomocnoEntitet
    {



        public Izbornik() 
        {
            //Pomocno.PomocnoIzbornik.DEV = true;

            obradaSmjer = new ObradaSmjer();
            obradaPolaznik = new ObradaPolaznik();
            obradaGrupa = new ObradaGrupa();
            pomocnoIzbornik = new PomocnoIzbornik();

            pomocnoIzbornik.UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************\n*** Edunova Console App v 1.0 ***\n*********************************");
        }


        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik\n1. Smjerovi\n2. Polaznici\n3. Grupe\n4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            
            switch(Pomocno.PomocnoObrada.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    Console.Clear();
                    obradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    obradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();                    
                    obradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    pomocnoIzbornik.SpremiPodatke();
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");                   
                    break;
            }
        }


       
    }
}
