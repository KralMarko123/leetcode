namespace Leetcode.Exercises.CSharp.Easy;

public static class MergeStringsAlternately
{
    public static string MergeAlternately(string word1, string word2)
    {
        var i = 0;
        var j = 0;
        var result = string.Empty;

        while (true)
        {
            if(i < word1.Length)
            {
                result += word1[i];
                i++;
            }
            
            if(j < word2.Length)
            {
                result += word2[j];
                j++;
            }
            
            if(i == word1.Length && j == word2.Length) break;
        }
        
        return result;
    }
}