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
                    if (sumZero > maxAmountZero)
                    {
                        maxAmountZero = sumZero;
                    }
                }
                else
                {                    
                    sumZero = 0;
                }                    
            }
            if (sumZero > maxAmountZero)
            {
                maxAmountZero = sumZero;
            }
            return maxAmountZero;
        }
    }
}
