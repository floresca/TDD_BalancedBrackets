using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBracketKATA
{
    class BalancedBracket
    {
       public string RunBalancedBracket(string input)
        {
            int strLength = input.Length - 1;

            if (input == "")
            {
                return string.Empty;
            }
            else if (input[0] == '[' && input[strLength] == ']' && input.Length % 2 == 0)
            {
                if (input.Length > 2)
                {
                    for (int i = 1; i < strLength; i++)
                    {
                        if (input[i] == input[strLength - i])
                        {
                            return "FAIL";
                        }
                    }
                }

                return "OK";
            }
            
            return "FAIL";
        }
    }
}
