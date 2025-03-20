public class Solution
{
    public int Search(int[] nums, int target)
    {
        int right = nums.Length - 1;
        int left = 0;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (target == nums[mid])
            {
                return mid;
            }

            if (target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }
}