public class Solution
{
    public int LongestNiceSubarray(int[] nums)
    {

        // use & to check if its nice
        // use |= to remove from currentOR

        int left = 0;
        int maxLength = 0;
        int currentOR = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            while ((currentOR & nums[right]) != 0)
            {
                currentOR ^= nums[left];
                left++;
            }

            currentOR |= nums[right];
            maxLength = Math.Max(maxLength, right - left + 1);

        }

        return maxLength;
    }
}