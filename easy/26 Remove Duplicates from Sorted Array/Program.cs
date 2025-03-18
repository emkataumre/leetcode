public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int uniquePosition = 1;
        for (int i = 1; i < nums.Length; i++)
        {


            if (nums[i] != nums[i - 1])
            {
                nums[uniquePosition] = nums[i];
                uniquePosition++;
            }
        }
        return uniquePosition;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = [1, 1, 2];
        int result = solution.RemoveDuplicates(nums);
        Console.WriteLine($"Length after removing duplicates: {result}");
    }
}
