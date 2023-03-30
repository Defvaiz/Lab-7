using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace L7
{
    public class Task4
    {
        public bool t4(string input)
        {
            if (input == null)
                throw new ArgumentException();
            Regex r3 = new Regex(@"^[\w_]+([_\-\.][\w_]+)*@([\w_]+\.)+[a-zA-Z]{2}$");
            if (r3.IsMatch(input))
                return true;
            else return false;
        }
    }
}
