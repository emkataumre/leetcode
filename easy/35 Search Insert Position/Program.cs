

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        int middle = (start + end) / 2;
        while (start <= end)
        {
            if (target == nums[middle]) return middle;
            else if (target < nums[middle])
            {
                end = middle - 1;
            }
            else if (target > nums[middle])
            {
                start = middle + 1;
            }
            middle = (start + end) / 2;
        }

        return start;

    }


}