public class Solution
{
    public int MaximumCount(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int posStart = nums.Length;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] >= 0)
            {
                posStart = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        left = 0;
        right = nums.Length - 1;
        int firstPositive = nums.Length;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > 0)
            {
                firstPositive = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        int negative_count = posStart;
        int positive_count = nums.Length - firstPositive;

        return Math.Max(negative_count, positive_count);

    }
}