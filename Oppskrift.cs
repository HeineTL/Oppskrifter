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

        public Oppskrift(string navn, List<string> instruksjoner, params Ingrediens[] ingredienser)
        {
            _navn = navn;
            _ingredienser = ingredienser;
            _instruksjoner = instruksjoner;
        }

        public void VisOppskrift()
        {
            Console.WriteLine("\n-------------------------------------------------------");

            Console.WriteLine(_navn);
            Console.WriteLine();
            Console.WriteLine("Ingredienser:");
            foreach (var ingrediens in _ingredienser)
            {
                ingrediens.VisIngrediens();
            }
            for (int i = 0; i < _instruksjoner.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}: {_instruksjoner[i]}");
            }

            Console.WriteLine("-------------------------------------------------------\n");
        }

        public bool HarIngrediens(string navn)
        {
            foreach (var ingrediens in _ingredienser)
            {
                if (ingrediens.MatcherNavn(navn))
                {
                    return true;
                }
            }
            return false;
        }

        public List<String> HentIngrediensNavn()
        {

            return _ingredienser.Select(i => i.Navn).ToList();

        }

        public bool InneholderAlleIngredienser(string[] ingredienserSomSkalSjekkes)
        {
            List<String> ingrediensNavn = HentIngrediensNavn();

            var inneholderIngredienser = ingrediensNavn.All(i => ingredienserSomSkalSjekkes.Contains(i));

            return inneholderIngredienser;
        }
    }
}
