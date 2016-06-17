using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Proxy
{
    class RealNumbers : SubjectNumbers
    {
        public int unlock = 0;
        public override void Reference(){
            if (unlock == 1){
                numbers();
            }
            if (unlock == 2)
            {
                EvenNumbers();
            }
            if (unlock == 3)
            {
                OddNumbers();
            }
        }
        public void numbers(){
            Console.WriteLine("Numbers: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9"  + "\n");
        }

        public void EvenNumbers(){
            Console.WriteLine("Even Numbers: 0, 2, 4, 6, 8" + "\n");
        }

        public void OddNumbers(){
            Console.WriteLine("Odd Numbers: 1, 3, 5, 7, 9" + "\n");
        }
    }
}
