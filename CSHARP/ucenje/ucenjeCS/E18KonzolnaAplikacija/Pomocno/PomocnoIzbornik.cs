using Newtonsoft.Json;
using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija.Pomocno
{
    internal class PomocnoIzbornik:PomocnoEntitet 
    {
        

        public static bool DEV = false;
        public PomocnoIzbornik()
        {
        }

        public void UcitajPodatke()
        {
            string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "smjerovi.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "smjerovi.json"));
                ObradaSmjer.Smjerovi = JsonConvert.DeserializeObject<List<Smjer>>(file.ReadToEnd());
            }

        }


        public void SpremiPodatke()
        {
            if (PomocnoIzbornik.DEV)
            {
                return;
            }

            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "smjerovi.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaSmjer.Smjerovi));
            outputFile.Close();
        }
    }
}
