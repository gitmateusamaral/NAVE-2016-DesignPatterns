using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Mediator
{
    class User
    {
        public int life;
        public int atk;
        public string name;

        public void init(int i)
        {
            life = 20;
            atk = 5;
            Console.WriteLine("Player " + (i+1) + " name:");
            name = Console.ReadLine();
        }

        public void attacking(User[] u)
        {
            Console.WriteLine(name +", who do you want to attack?");
            string who;
            who = Console.ReadLine();
            User def = Mediator.LookFor(who, u);

            if (def != null && def.life >= 0 && def.name != name)
                Mediator.Attack(this, def);
            else
            {
                Console.WriteLine("You can't attack this one, try again");
                attacking(u);
            }
        }



    }
}
