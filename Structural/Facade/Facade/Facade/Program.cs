using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name.");
            string name = Console.ReadLine();
            Console.WriteLine("What amount you want to invest?");
            string amount = Console.ReadLine();
            Console.WriteLine("When will you invest?[mm/dd/aaaa]");
            string t1 = Console.ReadLine();
            Console.WriteLine("When will you withdraw your investment?[mm/dd/aaaa]");
            string t2 = Console.ReadLine();
            Facade f = new Facade(name,t1,t2,float.Parse(amount));
            Console.WriteLine(" ");
            Console.WriteLine(f.exe());
            Console.Read();
        }
    }
}
