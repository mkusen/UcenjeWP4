
using ucenjeCS.E18KonzolnaAplikacija.Model;

namespace ucenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaSmjer
    {
        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer() 
        { 
        
            Smjerovi = new List<Smjer>();


        }   
        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s smjerovima");
            Console.WriteLine("1. Pregled svih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena podataka postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();


        }

        private void OdabirOpcijeIzbornika()
        {
           switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogSmjer();
                    PrikaziIzbornik();
                    break;

                    case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s smjerovima");
                    Console.Clear();
                    break;
            }
        }

        private void PrikaziSmjerove()
        {
            throw new NotImplementedException();
        }

        private void UnosNovogSmjer()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Unesite tražene podatke o smjeru");
            Smjerovi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true),
                Cijena = Pomocno.UcitajDecimalniBroj("Unwsi cijenu smjera", 0, 10000)
            });
        }
    }
}
