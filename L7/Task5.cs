using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7
{
    public class Task5
    {
        public int t5(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    throw new ArgumentException();
                }
                sum += str[i] - '0';
            }
            return sum;
        }
    }
}
