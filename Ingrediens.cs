using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Oppskrifter
{
    internal class Ingrediens
    {
        public string Navn { get; }
        private double _mengde;
        private string _enhet;

        public Ingrediens(string ingrediens, double mengde, string enhet)
        {
            Navn = ingrediens;
            _mengde = mengde;
            _enhet = enhet;
        }

        public void VisIngrediens()
        {
            Console.WriteLine($@"{Navn} - {_mengde} {_enhet}");
        }

        public bool MatcherNavn(string navn) => Navn == navn;

    }
}
