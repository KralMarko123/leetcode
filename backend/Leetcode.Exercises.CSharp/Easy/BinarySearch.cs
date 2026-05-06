
namespace Leetcode.Exercises.CSharp.Easy
{
    public static class BinarySearch
    {
        // Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.
        // If target exists, then return its index. Otherwise, return -1.
        // You must write an algorithm with O(log n) runtime complexity.
        public static int Search(int[] nums, int target)
        {
            var result = Array.BinarySearch(nums, target);
            return result < 0 ? 0 : result;
        }

        public static int SearchUsingOwnBinarySearch(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;

            while (start <= end)
            {
                var halfway = start + (end - start) / 2;
                
                if (nums[halfway] == target) return halfway;

                if (nums[halfway] > target) end = halfway - 1;
                else start = halfway + 1;
            }

            return -1;
        }
    }
}
