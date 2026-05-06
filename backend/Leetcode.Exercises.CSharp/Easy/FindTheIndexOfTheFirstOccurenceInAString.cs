
namespace Leetcode.Exercises.CSharp.Easy
{
    //Given two strings needle and haystack,
    //return the index of the first occurrence of needle in haystack,
    //or -1 if needle is not part of haystack.
    public static class FindTheIndexOfTheFirstOccurenceInAString
    {
        public static int FindIndexOfFirstOccurence(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i < needle.Length) return -1;

                if (haystack[i] == needle[0])
                {
                    var lettersPassed = 0;

                    for (int j = i; lettersPassed < needle.Length; j++)
                    {
                        if (haystack[j] == needle[lettersPassed]) lettersPassed++;
                        else break;
                    }

                    if (lettersPassed == needle.Length) return i;
                }
            }
            
            return -1;
        }
    }
}
