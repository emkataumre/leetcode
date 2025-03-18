public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0;
        int longest = 0;
        Dictionary<char, int> seen = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (seen.ContainsKey(s[i]))
            {
                left = Math.Max(left, seen[s[i]] + 1);

            }

            seen[s[i]] = i;
            longest = Math.Max(longest, i - left + 1);

        }
        return longest;

    }
}