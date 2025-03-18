public class Solution
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        int left = 1;
        int right = queries.Length;
        int ans = -1; // Store the minimum k

        while (left <= right) // Correct binary search condition
        {
            int mid = (left + right) / 2;
            int[] diff = new int[nums.Length + 1];
            int[] tempNums = (int[])nums.Clone(); // Create a copy to prevent modification

            for (int i = 0; i < mid; i++)
            {
                int l = queries[i][0];
                int r = queries[i][1];
                int val = queries[i][2];

                diff[l] -= val;
                if (r + 1 < diff.Length) diff[r + 1] += val;
            }

            int sum = 0;
            bool isZero = true;

            for (int i = 0; i < tempNums.Length; i++)
            {
                sum += diff[i];
                tempNums[i] += sum;
                if (tempNums[i] > 0) isZero = false; // If any number is not zero, it's invalid
            }

            if (isZero)
            {
                ans = mid; // Store possible answer
                right = mid - 1; // Try a smaller k 
            }
            else
            {
                left = mid + 1; // Need more queries
            }
        }

        return ans; // Return the smallest valid k or -1 if not possible
    }
}
