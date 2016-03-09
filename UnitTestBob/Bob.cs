using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestBob
{
    public class Bob
    {
       /* public string hey(string remark)
        {
            return remark;
        }*/
        public string hey(string remark)
        {
            if (remark.EndsWith("!"))
            {
                return "Whoa, chill out!";
            }
            return "Whatever.";
        }
    }
}
