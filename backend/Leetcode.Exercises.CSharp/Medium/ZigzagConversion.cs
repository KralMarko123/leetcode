namespace Leetcode.Exercises.CSharp.Medium
{
    // The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
    // P   A   H   N
    // A P L S I I G
    // Y   I   R
    // And then read line by line: "PAHNAPLSIIGYIR"
    // Write the code that will take a string and make this conversion given a number of rows:
    // string convert(string s, int numRows);
    public static class ZigzagConversion
    {
        public static string Convert(string s, int numRows)
        {
            var dict = new Dictionary<int, string>();
            bool flag = false;

            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(j)) dict.Add(j, s[i].ToString());
                else dict[j] += s[i].ToString();

                if (j == numRows - 1) flag = true;
                if (j == 0) flag = false;

                j = flag ? j - 1 : j + 1;
            }

            return string.Join("", dict.Values);
        }
    }
}
