using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppskrifter
{
    internal class Oppskrift
    {
        private string _navn;
        private Ingrediens[] _ingredienser;
        private List<string> _instruksjoner;

        public Oppskrift(string navn, List<string> instruksjoner, params Ingrediens[] ingredienser) { 
            _navn = navn;
            _ingredienser = ingredienser;
            _instruksjoner = instruksjoner;
        }

        public void VisOppskrift()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine(_navn);
            Console.WriteLine();
            Console.WriteLine("Ingredienser:");
            foreach(Ingrediens ingrediens in _ingredienser)
            {
                ingrediens.VisIngrediens();
            }
            for(int i = 0; i < _instruksjoner.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + " - " + _instruksjoner[i]);
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
        }

        public Oppskrift FinnIngrediens(string navn)
        {
            foreach(Ingrediens ingrediens in _ingredienser)
            {
                if(ingrediens.MatcherNavn(navn))
                {
                    return this;
                }
            }
            return null;
        }
    }
}
