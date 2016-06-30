using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class WTW
    {
        public int[] _l;
        public string[] date;
        //read text and sets values in an int array
        public WTW(string start, string end)
        {
            date = new string[2] { start, end };
            _l = new int[2];
            string[] lines = File.ReadAllLines("BitValue.bitv");
            using (StreamReader file = new StreamReader("BitValue.bitv"))
            {
                if (!string.IsNullOrWhiteSpace(file.ReadLine()))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Split('|')[0] == start){
                            _l[0] = i;
                            Console.Write("Start: " + i);
                        }
                        else if (lines[i].Split('|')[0] == end)
                        {
                            _l[1] = i;
                            Console.WriteLine("End: " + i);
                        } 
                    }
                }
            }
        }
    }
}
