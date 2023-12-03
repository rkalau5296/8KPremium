using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8KPremium
{
    internal class Pangram
    {
        public bool IsPangram(string sentence) 
        {
            string alphabet = "abcdefghijklmnoqprstuvwxyz";            

            bool result = false;           

            for(int i = 0; i<alphabet.Length; i++) 
            {
                if (sentence.Contains(alphabet.ToLower()[i])) 
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public bool IsPangramVer2(string sentence)
        {                      
            return "abcdefghijklmnoqprstuvwxyz".All(sentence.ToLower().Contains);
        }
    }
}
