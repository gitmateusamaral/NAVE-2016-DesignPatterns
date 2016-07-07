using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator.Start();

            User[] players = new User[Mediator.playerNum];
            User winner = new User();
            int pN = Mediator.playerNum;

            for (int i = 0; i < pN; i++)
            {
                players[i] = new User();
                players[i].init(i);
            }

            while (Mediator.playerNum > 1)
            {
                for (int i = 0; i < pN; i++)
                {
                    if(players[i].life > 0)
                        players[i].attacking(players);
                }
            }

            Console.ReadLine();
        }
               


    }
}
