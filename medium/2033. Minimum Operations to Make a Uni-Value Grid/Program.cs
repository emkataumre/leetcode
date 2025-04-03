public class Solution
{
    public int MinOperations(int[][] grid, int x)
    {
        if (grid.Length == 1)
        {
            return 0;
        }

        var elements = new List<(long Value, int Row, int Col)>();

        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int col = 0; col < grid[row].Length; col++)
            {
                elements.Add((grid[row][col], row, col));
            }
        }

        long baseValue = elements[0].Value;

        foreach (var e in elements)
        {
            if ((e.Value - baseValue) % x != 0)
            {
                return -1;
            }
        }

        var sortedElements = elements.OrderBy(e => e.Value).ToList();
        var sortedValues = elements.Select(e => e.Value).OrderBy(v => v).ToList();

        long medianValue = sortedValues[sortedValues.Count / 2];

        long result = 0;
        foreach (var sub in grid)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                long difference = Math.Abs((long)sub[i] - medianValue);

                Console.WriteLine($"val = {sub[i]}, median = {medianValue}, diff = {difference}");

                if (difference % x != 0)
                {
                    return -1;
                }

                result += (difference / x);
            }
        }

        return (int)result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] grid = new int[][]
        {
            new int[] { 1, 1, 10000 }
        };
        int x = 1;

        int result = solution.MinOperations(grid, x);
        Console.WriteLine($"Result: {result}");
    }
}