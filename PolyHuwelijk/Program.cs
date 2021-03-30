using System;
using System.Collections.Generic;

namespace PolyHuwelijk
{
    class Program
    {
        private static List<Vrouw> vrouwen = null;
        static void Main(string[] args)
        {
            vrouwen = new List<Vrouw>();
            NieuweVrouw(new Vrouw() { Naam = "Ilse" });
            NieuweVrouw(new Vrouw() { Naam = "Els" });
            NieuweVrouw(new Vrouw() { Naam = "Eva" });
            NieuweVrouw(new Vrouw() { Naam = "Karen" });
            NieuweVrouw(new Vrouw() { Naam = "Inge" });
            AanvragenVanVrouwen();
        }
        private static void NieuweVrouw(Vrouw vrouw)
        {
            vrouwen.Add(vrouw);
        }
        private static void AanvragenVanVrouwen()
        {
            foreach (Vrouw vrouw in vrouwen)
            {
                vrouw.GeefInstructiesAanEchtgenoot();
            }
        }
    }
}
