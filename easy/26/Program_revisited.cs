public class Solution_Revisited
{
    public int RemoveDuplicates_Revisited(int[] nums)
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
}
