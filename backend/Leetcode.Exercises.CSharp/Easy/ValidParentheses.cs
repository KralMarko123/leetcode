
namespace Leetcode.Exercises.CSharp.Easy
{
    public static class ValidParentheses
    {
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        // An input string is valid if:
        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.
        // Every close bracket has a corresponding open bracket of the same type.

        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var dictionary = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            foreach (char character in s)
            {
                if (dictionary.ContainsKey(character)) stack.Push(dictionary[character]);
                else if (stack.Count == 0 || character != stack.Pop()) return false;
            }

            return stack.Count == 0;
        }
    }
}
