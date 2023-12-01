using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8KPremium
{
    internal class JewelsAndStones
    {
        public int CountJewelsInStones(string jewels, string stones) 
        {
            int result = 0;

            for(int i = 0; i< jewels.Length; i++)
            {
                for(int j = 0; j < stones.Length; j++)
                {
                    if (stones[j] == jewels[i])
                        result++;
                }
            }
            return result;
        }

        public int CountJewelsInStonesVer2(string jewels, string stones)
        {
            int result = 0;
            for(int i = 0; i<jewels.Length; i++)
            {
                result += stones.Count(c => c == jewels[i]);
            }
            return result;
        }
    }
}
