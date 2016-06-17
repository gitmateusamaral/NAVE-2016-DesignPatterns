using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Proxy
{
    class Program
    {
        static void Main(string[] args){
            ProxyNumbers pN = new ProxyNumbers();
            Console.WriteLine("Press ENTER to access the content");
            pN.password = Console.ReadLine();
            pN.Reference();
        }
    }
}
