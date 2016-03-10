using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestBob
{
    public class Bob
    {
        public string hey(string remark)
        {
            if (remark.EndsWith("!"))
            {
                return "Whoa, chill out!";
            }

            if (remark.Length == 26)
            {
                return "Fine. Be that way!";
            }

            if (remark.EndsWith("?"))
            {
                return "Sure.";
            }

            if (remark.EndsWith("?") && remark.Length == 26)
            {
                return "Fine. Be that way!";
            }

            if (remark == "")
            {
                return "Fine.Be that way!";
            }
            

           public  bool IsAllUpper(string input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!Char.IsUpper(input[i]) || Char.IsWhiteSpace(input[i]) 
                         || Char.IsDigit(input[i]) || Char.IsPunctuation(input[i]))
                        return false;
                }

                return true;
            }
            
            return "Whatever.";

        }

        
    }
}


