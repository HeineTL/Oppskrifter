using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppskrifter
{
    internal class Oppskrifter
    {
        private List<Oppskrift> _oppskrifter;

        public Oppskrifter()
        {
            Oppskrift pannekaker = new Oppskrift(
                "Pannekaker",
                new List<string> {
                    "Bland mel og salt. Tilsett halvparten av melken. Visp sammen til en tykk og klumpfri røre. Tilsett resten av melken. Visp inn egg. La pannekakerøren svelle i ca. ½ time. Ikke spar på eggene i en pannekakerøre. Eggende binder røren, slik at du kan bruke mindre mel. Da blir det tynne og fine pannekaker.",
                    "Smelt smør eller margarin i en god og varm stekepanne. Hell i en øse med pannekakerøre og vend på pannen, slik at røren legger seg i et jevnt lag. Snu pannekaken når den har stivnet på oversiden og blitt gyllenbrun på undersiden.",
                    "Når pannekaken er stekt på begge sider, brettes den sammen og legges i et ildfast fat med lokk. Pannekakene holder da varmen, slik at alle kan spise sammen."
                },

                new Ingrediens("Egg", 4, "stk"),
                new Ingrediens("Mel", 3, "dl"),
                new Ingrediens("Salt", 0.5, "ts"),
                new Ingrediens("Melk", 5, "dl"),
                new Ingrediens("Smør", 1, "ss")
            );

            Oppskrift omelett = new Oppskrift(
                "Omelett",
                new List<string> {
                    "Visp sammen egg, melk og salt.",
                    "Smelt smøret i stekepanna, til det freser. Hell i eggeblandingen. Stek omeletten ved å skyve den stivnede massen inn mot midten, slik at det som fortsatt er flytende kommer i direkte kontakt med panna.",
                },

                new Ingrediens("Egg", 2, "stk"),
                new Ingrediens("Salt", 0.25, "ts"),
                new Ingrediens("Smør", 1, "ss")
            );

            Oppskrift hveteboller = new Oppskrift(
                "Hveteboller",
                new List<string> {
                    "Ha mel, sukker, gjær, salt, kardemomme og egg i en bolle. Legg salt og gjær på hver sin side i bollen. Tilsett temperert melk og elt deigen godt sammen.",
                    "Tilsett romptemperert smør i biter og elt videre i 2-3 minutter på lav hastighet. Øk hastigheten og elt i ca. 5 minutter til.",
                    "Dekk bollen med håndkle eller plast, og la deigen heve 30-40 minutter til dobbel størrelse.",
                    "Sett ovnen på 210 °C. Hell deigen ut på et melet bord. Del i emner og rull til boller.",
                    "Legg bollene med god avstand på et stekebrett dekket med bakepapir og la etterheve til dobbel størrelse, 10-20 minutter. Pensle med lettpisket egg og stek gylne i ovnen i 10-15 minutter. Avkjøl på rist."
                },

                new Ingrediens("Mel", 17, "dl"),
                new Ingrediens("Sukker", 2, "dl"),
                new Ingrediens("Gjær", 50, "g"),
                new Ingrediens("Salt", 1, "ts"),
                new Ingrediens("Egg", 1, "stk"),
                new Ingrediens("Melk", 6, "dl"),
                new Ingrediens("Smør", 150, "g")
            );

            _oppskrifter = new List<Oppskrift> { pannekaker, omelett, hveteboller };
        }

        public void FinnOppskrifterMedIngrediens(string ingrediensNavn)
        {
            List<Oppskrift> oppskrifterMedIngrediens = new List<Oppskrift>();

            foreach (Oppskrift oppskrift in _oppskrifter)
            {
                if(oppskrift.FinnIngrediens(ingrediensNavn))
                {
                    oppskrifterMedIngrediens.Add(oppskrift);
                }
            }

            foreach(Oppskrift oppskrift in oppskrifterMedIngrediens)
            {
                oppskrift.VisOppskrift();
            }
        }

        public void FinnOppskrifterManKanLage(params string[] ingredienser)
        {
            List<Oppskrift> oppskrifterManKanLage = new List<Oppskrift>();

            foreach(Oppskrift oppskrift in _oppskrifter)
            {
                //Finn ut om alle oppskriftene stemmer, sjekk i Oppskrift.cs
                if(oppskrift.InneholderAlleIngredienser(ingredienser))
                {
                    oppskrifterManKanLage.Add(oppskrift);
                }
            }

            foreach(Oppskrift oppskrift in oppskrifterManKanLage)
            {
                oppskrift.VisOppskrift();
            }
        }
    }
}
