
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.
    public static class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string columnTitle)
        {
            int result = 0;
            var dictionary = new Dictionary<char, int>()
            {
                { 'A', 1 },
                { 'B', 2 },
                { 'C', 3 },
                { 'D', 4 },
                { 'E', 5 },
                { 'F', 6 },
                { 'G', 7 },
                { 'H', 8 },
                { 'I', 9 },
                { 'J', 10 },
                { 'K', 11 },
                { 'L', 12 },
                { 'M', 13 },
                { 'N', 14 },
                { 'O', 15 },
                { 'P', 16 },
                { 'Q', 17 },
                { 'R', 18 },
                { 'S', 19 },
                { 'T', 20 },
                { 'U', 21 },
                { 'V', 22 },
                { 'W', 23 },
                { 'X', 24 },
                { 'Y', 25 },
                { 'Z', 26 },
            };

            for (int i = 0; i < columnTitle.Length; i++)
            {
                result += (int)Math.Pow(26, columnTitle.Length - i - 1) * dictionary[columnTitle[i]];
            }

            return result;
        }
    }
}