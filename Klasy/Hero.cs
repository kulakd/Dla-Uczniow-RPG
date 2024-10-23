using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Klasy
{
    public class Hero
    {
        public int Hp;
        public string Nazwa;
        public int Atak;
        public Hero(string nazwa, int hp, int atak)
        {
            Nazwa = nazwa;
            Hp = hp;
            Atak = atak;
        }
        public void WyswietlStatystyki()
        {
            Console.WriteLine($"Postać {Nazwa} posiada {Hp} życia i {Atak} pkt ataku.");
            Console.WriteLine();
        }
    }
}
