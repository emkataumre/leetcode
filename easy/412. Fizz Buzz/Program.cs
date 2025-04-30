public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> answer = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string result = "";

            if (i % 3 == 0) result += "Fizz";
            if (i % 5 == 0) result += "Buzz";
            if (result == "") result = i.ToString();

            answer.Add(result);
        }

        return answer;

    }
}