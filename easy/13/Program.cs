/*
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
*/
/*
I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
*/

Dictionary<string, int> romanNumeralValues = new()
{
    ["I"] = 1,
    ["V"] = 5,
    ["X"] = 10,
    ["L"] = 50,
    ["C"] = 100,
    ["D"] = 500,
    ["M"] = 1000
};

int RomanToInt(string romanNumeral)
{

    // Map over the string and find out which numerals it contains and assign their numbers,

    List<int> numeralValues = new List<int>();

    foreach (char numeral in romanNumeral)
    {
        if (romanNumeralValues.TryGetValue(numeral.ToString(), out int value))
        {
            numeralValues.Add(value);
        }
    }

    //Console.WriteLine(string.Join(", ", numeralValues));

    // Look through the result from left to right and compare each character to the next
    int result = 0;
    for (int i = 0; i < numeralValues.Count - 1; i++)
    {

        if (numeralValues[i] >= numeralValues[i + 1])
        {
            result += numeralValues[i];
        }
        else
        {
            result -= numeralValues[i];
        }
    }

    result += numeralValues[^1];
    Console.WriteLine(result);
    return result;

}

RomanToInt("MMMCMXCIX");