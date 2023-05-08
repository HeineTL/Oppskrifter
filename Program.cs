using System;
using System.Collections.Generic;
using System.Data;

namespace Oppskrifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oppskrifter oppskrifter = new Oppskrifter();

            //viser pannekaker og omelett
            oppskrifter.FinnOppskrifterManKanLage("Egg", "Smør", "Salt", "Mel", "Sukker", "Melk");

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            //viser kun hveteboller
            oppskrifter.FinnOppskrifterMedIngrediens("Gjær");
        }
    }
}
