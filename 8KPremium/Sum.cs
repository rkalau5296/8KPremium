internal class Sum
{
    public bool IsSumExist(List<int> numbers, int k)
    {
        bool result = false;
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    continue;
                }
                if (numbers[i] + numbers[j] == k)
                {
                    result = true;
                    break;
                }
            }
            if (result)
            {
                break;
            }
        }
        return result;
    }
    public bool IsSumExistVer2(List<int> numbers, int k)
    {
        return numbers.Any(x => numbers.Any(y => x + y == k));
    }
}

