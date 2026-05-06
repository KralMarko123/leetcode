
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given an array nums of size n, return the majority element.
    // The majority element is the element that appears more than ⌊n / 2⌋ times.
    // You may assume that the majority element always exists in the array.
    public static class MajorityElement
    {
        public static int FindMajorityElement(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num]++;
                    if (dictionary[num] > nums.Length / 2) return num;
                }
                else dictionary.Add(num, 1);
            }

            return dictionary.Keys.FirstOrDefault();
        }
    }
}
