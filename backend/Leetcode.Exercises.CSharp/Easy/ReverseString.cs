namespace Leetcode.Exercises.CSharp.Easy
{
    // Write a function that reverses a string. The input string is given as an array of characters s.
    // You must do this by modifying the input array in-place with O(1) extra memory.
    public static class ReverseString
    {
        public static void Reverse(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                var tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
            }
        }
    }
}
