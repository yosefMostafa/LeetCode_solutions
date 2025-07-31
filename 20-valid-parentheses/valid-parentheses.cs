public class Solution {
    public bool IsValid(string s) {
           if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
        return false;

    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> pairs = new Dictionary<char, char>
    {
        {')', '('},
        {']', '['},
        {'}', '{'}
    };

    foreach (char c in s)
    {
        if (pairs.ContainsKey(c)) // Closing parenthesis
        {
            if (stack.Count == 0 || stack.Peek() != pairs[c])
                return false;

            stack.Pop();
        }
        else // Opening parenthesis
        {
            stack.Push(c);
        }
    }

    return stack.Count == 0;
    }
}