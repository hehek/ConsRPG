using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public abstract class Character
    {
        public string name;
        public WeaponBehavior weapon;

        public abstract void display();    
             
        public void setWeapon(WeaponBehavior weapon)
        {
            this.weapon = weapon;
        }
    }
       
    public class Knight: Character
    {
        public Knight()
        {
            name = "Knight";
            weapon = new SwardBehavior();
        }

        public override void display()
        {
            Console.WriteLine("{0}" , name);
            weapon.Attac();
        }
    }

    public class Archer : Character
    {
        public Archer()
        {
            name = "Archer";
            weapon = new BowBehavior();
        }

        public override void display()
        {
            Console.WriteLine("{0}", name);
            weapon.Attac();
        }
    }
    public class Warlock : Character
    {
        public Warlock()
        {
            name = "Warlock";
            weapon = new WandBehavior();
        }

        public override void display()
        {
            Console.WriteLine("{0}", name);
            weapon.Attac();
        }
    }

}
