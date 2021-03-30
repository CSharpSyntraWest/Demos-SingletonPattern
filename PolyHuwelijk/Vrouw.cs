using System;
using System.Collections.Generic;
using System.Text;

namespace PolyHuwelijk
{
    public class Vrouw
    {
        public string Naam {get;set;}
        public Man Echtgenoot {get;set;} = Man.Instance;

        public void GeefInstructiesAanEchtgenoot()
        {
            Echtgenoot.GrasAfRijden();
            Echtgenoot.ComplimentGeven("Kleedje");
            Echtgenoot.LampVervangen();
            Echtgenoot.KaderOphangen();
            Echtgenoot.VuilbakBuitenZetten();
        }
    }
}
