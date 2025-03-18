public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        int n = s.Length;
        Dictionary<char, int> charCount = new Dictionary<char, int>()
        {
            {'a', 0},
            {'b', 0},
            {'c', 0}
        };
        int left = 0;
        int result = 0;

        for (int right = 0; right < n; right++)
        {
            charCount[s[right]]++;


            while (charCount['a'] > 0 && charCount['b'] > 0 && charCount['c'] > 0)
            {
                result += (n - right);
                charCount[s[left]]--;
                left++;
            }
        }

        return result;
    }
}
