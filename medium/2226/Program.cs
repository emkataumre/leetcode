public class Solution
{
    public int MaximumCandies(int[] candies, long k)
    {

        if (candies.Sum() < k || candies.Length == 0)
        {
            return 0;
        }

        if (k == 1)
        {
            return candies.Sum();
        }

        int low = 1;
        int high = candies.Max();
        long count = 0;
        while (low <= high)
        {
            int mid = (low + high) / 2;

            foreach (var candy in candies)
            {
                count += candy / mid;
            }

            if (count >= k)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return high;
    }
}