public class Solution
{
    public string LongestCommonPrefix(string[] strings)
    {
        string referenceString = strings[0];
        string commonPrefix = referenceString;
        foreach (string currentString in strings)
        {
            // If first characters don't match, no common prefix exists
            if (currentString.Length == 0 || commonPrefix[0] != currentString[0])
            {
                return "";
            }

            for (int position = 0; position < Math.Min(commonPrefix.Length, currentString.Length); position++)
            {
                if (commonPrefix[position] != currentString[position])
                {
                    commonPrefix = commonPrefix.Substring(0, position);
                    break;
                }
            }
            // Update prefix length to match shorter string if needed
            commonPrefix = commonPrefix.Substring(0, Math.Min(commonPrefix.Length, currentString.Length));
        }

        return commonPrefix;
    }
}