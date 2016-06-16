using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Amount
    {
        public float _amount;
        public float _actualAmount;
        public Amount(float f)
        {
            _amount = f;
        }
        public float returnProfit(int[] t)
        {
            string[] lines = File.ReadAllLines("BitValue.bitv");
            using (StreamReader file = new StreamReader("BitValue.bitv"))
            {
                if (!string.IsNullOrWhiteSpace(file.ReadLine()))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (i == t[0])
                        {
                            _actualAmount = _amount / (float.Parse(lines[i].Split('|')[1]));
                        }
                        else if (i == t[1])
                        {
                            return _actualAmount * (float.Parse(lines[i].Split('|')[1]));
                        }
                    }
                }
            }
            return 0;
        }
    }
}
