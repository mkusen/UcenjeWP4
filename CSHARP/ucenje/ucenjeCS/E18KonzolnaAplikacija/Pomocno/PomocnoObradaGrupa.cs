using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija.Pomocno
{
    internal class PomocnoObradaGrupa
    {
        public List<Grupa> Grupe { get; set; }
        private Izbornik Izbornik;

        public PomocnoObradaGrupa()
        {
            Grupe = new List<Grupa>();
        }
        public PomocnoObradaGrupa(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }
        public void Brisanje()
        {
            var g = Grupe[
            PomocnoObrada.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1
            ];
        }

        public void ObrisiGrupu()
        {
            PrikaziGrupe();

            if (PomocnoObrada.UcitajBool("Sigurno obrisati " + g.Naziv + "? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        public void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[
                PomocnoObrada.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1
                ];
            // copy paste s linije 102 - izvući u metodu
            g.Sifra = PomocnoObrada.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = PomocnoObrada.UcitajString("Unesi naziv grupe", 50, true);
            //smjer
            Izbornik.obradaSmjer.PrikaziSmjerove();

            g.Smjer = Izbornik.obradaSmjer.Smjerovi[
                PomocnoObrada.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.obradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = PomocnoObrada.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = PomocnoObrada.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike();


        }

        public void PrikaziGrupe()
        {
            Console.WriteLine("*****************************\nGrupe u aplikaciji");
            int rb = 0, rbp;
            foreach (var g in Grupe)
            {
                Console.WriteLine(++rb + ". " + g.Naziv + " (" + g.Smjer?.Naziv + "), " + g.Polaznici?.Count + " polaznika"); // prepisati metodu toString
                rbp = 0;
                g.Polaznici.Sort();
                foreach (var p in g.Polaznici)
                {
                    Console.WriteLine("\t" + ++rbp + ". " + p.Ime + " " + p.Prezime);
                }
            }
            Console.WriteLine("****************************");
        }

        public void UnosNoveGrupe()
        {
            Console.WriteLine("***************************\nUnesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = PomocnoObrada.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = PomocnoObrada.UcitajString("Unesi naziv grupe", 50, true);
            //smjer
            Izbornik.obradaSmjer.PrikaziSmjerove();

            g.Smjer = Izbornik.obradaSmjer.Smjerovi[
                PomocnoObrada.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.obradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = PomocnoObrada.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = PomocnoObrada.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike();

            Grupe.Add(g);
        }

        public List<Polaznik> UcitajPolaznike()
        {
            List<Polaznik> lista = new List<Polaznik>();
            while (PomocnoObrada.UcitajBool("Za unos polaznika unesi DA", "da"))
            {
                Izbornik.obradaPolaznik.PrikaziPolaznike();
                lista.Add(
                    Izbornik.obradaPolaznik.Polaznici[
                        PomocnoObrada.UcitajRasponBroja("Odaberi redni broj polaznika", 1,
                        Izbornik.obradaPolaznik.Polaznici.Count) - 1
                        ]
                    );
            }

            return lista;
        }


    }

}

