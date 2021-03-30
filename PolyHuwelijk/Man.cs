using System;
using System.Collections.Generic;

namespace PolyHuwelijk
{
    public sealed class Man
    {
        private static readonly Man man = new Man();
        public const string Naam = "Jos";
        public static Man Instance
        {
            get
            {
                return man;
            }
        }

        public void VuilbakBuitenZetten()
        {

            Console.WriteLine(Naam + " heeft de vuilbak buitengezet");
        }

        public void GrasAfRijden()
        {

            Console.WriteLine(Naam + " heeft het gras afgereden");
        }

        public void LampVervangen()
        {

            Console.WriteLine(Naam + " heeft lamp vervangen");
        }

        public void KaderOphangen()
        {

            Console.WriteLine(Naam + " heeft kader opgehangen");
        }

        public void ComplimentGeven(string input)
        {

            Console.WriteLine($"{Naam} zegt: 'Ik vind je {input} heel mooi'");
        }

    }
}
