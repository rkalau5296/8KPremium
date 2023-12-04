public class Brace
{
    public static bool validBraces(String braces)
    {
        Stack<char> stos = new();

        foreach (char znak in braces)
        {
            if (znak == '(' || znak == '[' || znak == '{')
            {
                stos.Push(znak);
            }
            else if (znak == ')' || znak == ']' || znak == '}')
            {
                if (stos.Count == 0)
                {
                    return false;
                }

                char odpowiadajacyNawias = stos.Peek();

                if (znak == ')' && odpowiadajacyNawias == '(' ||
                    znak == ']' && odpowiadajacyNawias == '[' ||
                    znak == '}' && odpowiadajacyNawias == '{')
                {
                    stos.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stos.Count == 0;
    }
}