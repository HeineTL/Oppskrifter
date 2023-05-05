using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppskrifter
{
    internal class Ingrediens
    {
        private string _navn;
        private double _mengde;
        private string _enhet;

        public Ingrediens(string ingrediens, double mengde, string enhet)
        {
            _navn = ingrediens;
            _mengde = mengde;
            _enhet = enhet;
        }

        public void VisIngrediens()
        {
            Console.WriteLine($@"{_navn} - {_mengde} {_enhet}");
        }

        public bool MatcherNavn(string navn)
        {
            if (_navn == navn)
            {
                return true;
            }
            return false;
        }
    }
}
