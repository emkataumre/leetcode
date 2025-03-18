public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            Console.WriteLine(false);
            return false;
        }

        if (x >= 0 && x < 10)
        {
            Console.WriteLine(true);
            return true;
        }

        long reversed_value = ReverseInt(x);

        if (x == reversed_value)
        {
            Console.WriteLine(true);
            return true;
        }
        else
        {
            Console.WriteLine(false);
            return false;
        }
    }

    static long ReverseInt(long i)
    {
        List<long> digits = new List<long>();

        while (i > 0)
        {
            digits.Add(i % 10);
            i /= 10;
        }

        string numberStr = string.Join("", digits);
        return long.Parse(numberStr);
    }
}