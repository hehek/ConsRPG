using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public abstract class Character
    {
        string name;
        WeaponBehavior weapon;

        public abstract void display();    
        public void Attac()
        {
            weapon.Attac();
        }     
        public void setWeapon(WeaponBehavior weapon)
        {
            this.weapon = weapon;
        }
    }
       

}
