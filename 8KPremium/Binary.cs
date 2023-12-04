namespace _8KPremium
{
    internal class Binary
    {
        public int BinaryGap(int number) 
        {
            string numberString = number.ToString();
            int sumZero = 0;
            int maxAmountZero = 0;

            for (int i = 0; i< numberString.Length; i++) 
            {
                if (numberString[i] == '0')
                {
                    sumZero++;                    
                }
                else
                {
                    if (sumZero > maxAmountZero)
                    {
                        maxAmountZero = sumZero;
                    }
                    sumZero = 0;
                }                    
            }
            
            return maxAmountZero;
        }
        public int BinaryGapVer2(int number)
        {
            return number.ToString().Split('1')
                        .Select(z => z.Length)
                        .Max();             
        }
    }
}
