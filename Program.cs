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

            oppskrifter.FinnOppskrifterMedIngrediens("Mel");
        }
    }
}
