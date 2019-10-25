using System;

namespace NamingParameters
{
    // Bonne pratique
    public class VolDto
    {
        public DateTime dateInitial;
        public DateTime dateFinal;
        public string noms;
        public string compagnie;
    }

    public static class Reserve
    {
        //Mauvaise pratique
        //public static string Reserver(DateTime dateInitial, DateTime dateFinal, string noms, string compagnie)
        //{
        //    return $"{noms} a reserver le vol pour {dateInitial} jusqu'au {dateFinal} pour la compagnie {compagnie}";
        //}

        // Bonne pratique
        public static string Vol(VolDto reserver)
        {
            return $"{reserver.noms} a reserver le vol pour " +
                   $"{reserver.dateInitial} jusqu'au {reserver.dateFinal} pour la compagnie " +
                   $"{reserver.compagnie}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // C'est un cas utilisant les parametres només.
            //Console.WriteLine(
            //    ReserveVol.Reserver(
            //        dateInitial: DateTime.Now,
            //        dateFinal: DateTime.Now,
            //        noms: "Billy Tukija Richard",
            //        compagnie: "Air France"));

            //Notez bien, la meilleur façon de faire, c'est de gréer un object Dto (Data Transfert Object)

            //Bonne pratique
            var infos = new VolDto()
            {
                noms = "Graziel Tukija",
                dateInitial = DateTime.Now,
                dateFinal = DateTime.Now.AddDays(15),
                compagnie = "Air France"
            };

            Console.WriteLine(Reserve.Vol(infos));
        }
    }
}
