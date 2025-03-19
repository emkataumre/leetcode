public class Solution
{
    public int MinOperations(int[] nums)
    {
        int minOperations = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                continue;
            }

            if (nums[i] == 0 && (i + 2) < nums.Length)
            {
                nums[i] = 1;
                nums[i + 1] = nums[i + 1] == 0 ? 1 : 0;
                nums[i + 2] = nums[i + 2] == 0 ? 1 : 0;

                minOperations++;

            }
        }

        foreach (int num in nums)
        {
            if (num == 0) return -1;
        }

        return minOperations;
    }
}