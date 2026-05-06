
using System.Text;

namespace Leetcode.Exercises.CSharp.Easy
{
    public static class SummaryRanges
    {
        // You are given a sorted unique integer array nums.
        // A range[a, b] is the set of all integers from a to b(inclusive).
        // Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
        // That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.
        // Each range[a, b] in the list should be output as:
        // "a->b" if a != b
        // "a" if a == b

        public static IList<string> GetSummaryRanges(int[] nums)
        {
            var start = 0;
            var end = 0;
            var result = new List<string>();

            if (nums.Length == 0) return result;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1] + 1) end = i;
                else
                {
                    AddToResult(result, nums, start, end);
                    start = i;
                    end = i;
                }
            }

            AddToResult(result, nums, start, end);

            return result;
        }

        private static void AddToResult(List<string> result, int[] nums, int start, int end)
        {
            if (start == end) result.Add(nums[end].ToString());
            else result.Add($"{nums[start]}->{nums[end]}");
        }

    }
}
