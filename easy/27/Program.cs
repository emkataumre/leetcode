public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 1 && nums[0] != val)
        {
            return 1;
        }

        int uniquePosition = 0;
        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] != val)
            {
                nums[uniquePosition] = nums[i];
                uniquePosition++;
            }
            else
            {

            }
        }
        return uniquePosition;
    }
}