using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Klasy
{
    public class Mag : Hero
    {
        public int Moc;
        public Mag(string nazwa, int hp, int atak, int moc)
        : base(nazwa, hp, atak)
        {
            Moc = moc;
        }
        public void OdejmijHp(int atak)
        {
            Hp -= atak;
        }
        public int PobierzSileAtaku()
        {
            return Atak + Moc / 5;
        }
    }
}
