namespace Leetcode.Exercises.CSharp.Medium;

public static class LetterCombinationsOfAPhoneNumber
{
    private static readonly Dictionary<char, string> PhoneLetterCombinations = new()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    public static IList<string> LetterCombinations(string digits)
    { 
        var result = new List<string>();

        if (string.IsNullOrEmpty(digits)) return result;

        BuildCombinations(digits, 0, string.Empty, result);

        return result;
    }

    private static void BuildCombinations(string digits, int index, string current, IList<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(current);
            return;
        }

        foreach (var letter in PhoneLetterCombinations[digits[index]])
        {
            BuildCombinations(digits, index + 1, current + letter, result);
        }
    }
}
