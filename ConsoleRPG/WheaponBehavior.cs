using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public interface WeaponBehavior
    {
        void Attac();
    }

    class BowBehavior : WeaponBehavior
    {
        int maxDamage = 50;
        int minDamage = 10;
        Random rand = new Random();

        public void Attac()
        {            
            Console.WriteLine("Weapon: Bow \nDamage: {0}", rand.Next(minDamage,maxDamage));
        }
    }

    class SwardBehavior : WeaponBehavior
    {
        int maxDamage = 55;
        int minDamage = 30;
        Random rand = new Random();

        public void Attac()
        {
            Console.WriteLine("Weapon: Sward \nDamage: {0}", rand.Next(minDamage, maxDamage));
        }
    }

    class WandBehavior : WeaponBehavior
    {
        int maxDamage = 60;
        int minDamage = 5;
        Random rand = new Random();

        public void Attac()
        {
            Console.WriteLine("Weapon: Stick \nDamage: {0}", rand.Next(minDamage, maxDamage));
        }
    }


}
