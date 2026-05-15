namespace Leetcode.Exercises.CSharp.Easy;

public static class GreatestCommonDivisorOfStrings
{
    public static string GcdOfStrings(string str1, string str2) 
    {
        // checks if they have same letters and order of letters
        if (!(str1 + str2).Equals(str2 + str1)) return "";

        var a = str1.Length; 
        var b = str2.Length;
        
        while (b > 0) {
            var temp = b;
            b = a % b;
            a = temp;
        }
        
        return str1[..a];
    }
}