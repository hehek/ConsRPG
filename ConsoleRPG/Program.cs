using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Knight();
            Character archer = new Archer();
            Character warlock = new Warlock();

            knight.display();
            archer.display();
            warlock.display();

            Console.ReadKey();

        }
    }
}
