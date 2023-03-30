using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace L7
{
    public class Task3
    {
        public bool t3(int year)
        {
            if (year < 0 || year == 0)
                throw new ArgumentException();
            else
            {
                if (DateTime.IsLeapYear(year))
                    return true;
                else return false;
            }
        }
    }
}
