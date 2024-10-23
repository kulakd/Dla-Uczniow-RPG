using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Klasy
{
    public class GeneratorPostaci
    {
        private Random LiczbyLosowe;
        private List<string> Imiona;
        public GeneratorPostaci()
        {
            LiczbyLosowe = new Random();
            Imiona = new List<string>
            {
                "Vladimir",
                "Nieznajomy",
                "Max",
                "Veigar",
                "Gerard"
            };
        }
        public Mag GenerujMaga()
        {
            int hp = LiczbyLosowe.Next(150, 300);
            int atak = LiczbyLosowe.Next(5, 15);
            string imie = Imiona[LiczbyLosowe.Next(0, Imiona.Count)];
            Imiona.Remove(imie);
            Mag mag = new Mag(imie, hp, atak, 10);
            return mag;
        }
        public Wojownik GenerujWojownika()
        {
            int hp = LiczbyLosowe.Next(150, 300);
            int atak = LiczbyLosowe.Next(5, 15);
            string imie = Imiona[LiczbyLosowe.Next(0, Imiona.Count)];
            Imiona.Remove(imie);
            Wojownik wojownik = new Wojownik(imie, hp, atak, 5);
            return wojownik;
        }
    }
}
