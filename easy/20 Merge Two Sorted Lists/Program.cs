bool IsValid(string input)
{
    //Create a stack of characters

    //When i encounter an opening bracket, push it to the top of the stack

    // When i encouter a closeing bracket, check if it has a na opening bracket

    char[] characters = input.ToCharArray();

    Stack<char> brackets = new Stack<char>();

    foreach (char c in characters)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            brackets.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            char expectedOpening = c == ')' ? '(' : (c == '}' ? '{' : '[');
            if (brackets.Count == 0 || brackets.Peek() != expectedOpening)
            {
                return false;
            }
            else
            {
                brackets.Pop();
            }
        }
    }

    return brackets.Count == 0;
}

IsValid("()");
