using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Proxy
{
    class ProxyNumbers : SubjectNumbers
    {
        public string password;
        public RealNumbers rN = new RealNumbers();
    
        public override void Reference()
        {
            if (password == "123"){
                rN.unlock = 2;
                rN.Reference();
            }
            else if (password == "321"){
                rN.unlock = 3;
                rN.Reference();
            }
            else if (password == "123321") {
                rN.unlock = 1;
                rN.Reference();
            }else{
                Console.WriteLine(" :'( The proxy isn't responding" + "\n");
                Console.WriteLine("Press ENTER to access the content");
            }
            password = Console.ReadLine();
            Reference();
            rN.Reference();
        }
    }
}
