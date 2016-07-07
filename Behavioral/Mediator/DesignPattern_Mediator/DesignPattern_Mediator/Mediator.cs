using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Mediator
{
    class Mediator
    {
        public static int playerNum;
        public static void Attack(User att, User def)
        {
            Console.WriteLine("Player " + att.name + " attacks " + "Player " + def.name);
            def.life -= att.atk;
            Console.WriteLine("Player " + def.name + " loses " + att.atk + " hitpoints, he has " + def.life + " remaining");

            if (def.life <= 0)
            {
                Console.WriteLine("Player " + att.name + " killed " + "Player " + def.name);
                playerNum--;
                if (playerNum <= 1)
                    Console.WriteLine(att.name + " won!");
            }
        }

        public static void Start()
        {
            Console.WriteLine("Number of Players:");
            playerNum = int.Parse(Console.ReadLine());
        }

        public static User LookFor(String x, User[] u)
        {
            for (int i = 0; i < playerNum; i++)
            {
                if(u[i].name.Equals(x))
                {
                    return u[i];
                }
            }

            return null;
        }

    }
}
