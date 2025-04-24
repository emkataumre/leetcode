public class Solution
{
    public int CountCompleteSubarrays(int[] nums)
    {
        int totalUniqueValues = new HashSet<int>(nums).Count;
        int result = 0;

        Dictionary<int, int> freq = new();
        int left = 0, distinctCount = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (!freq.ContainsKey(nums[right]))
            {
                freq[nums[right]] = 0;
                distinctCount++;
            }
            freq[nums[right]]++;

            while (distinctCount == totalUniqueValues)
            {
                result += nums.Length - right;

                freq[nums[left]]--;
                if (freq[nums[left]] == 0)
                {
                    freq.Remove(nums[left]);
                    distinctCount--;
                }
                left++;
            }
        }

        return result;
    }
}
