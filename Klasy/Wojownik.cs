using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Klasy
{
    public class Wojownik : Hero
    {
        public int Obrona;
        public Wojownik(string nazwa, int hp, int atak, int obrona)
        : base(nazwa, hp, atak)
        {
            Obrona = obrona;
        }
        public void OdejmijHp(int atak)
        {
            Hp -= atak - Obrona / 3;
        }
        public int PobierzSileAtaku()
        {
            return Atak;
        }
    }
}
