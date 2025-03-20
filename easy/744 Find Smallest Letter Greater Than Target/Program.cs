public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int left = 0;
        int right = letters.Length - 1;
        int result = -1;
        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (letters[mid] > target)
            {
                result = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result == -1 ? letters[0] : letters[result];
    }
}