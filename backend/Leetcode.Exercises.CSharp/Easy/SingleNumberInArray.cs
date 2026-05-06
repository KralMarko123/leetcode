
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
    // You must implement a solution with a linear runtime complexity and use only constant extra space.
    public static class SingleNumberInArray
    {
        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            var dicitonary = new Dictionary<int, bool>();

            foreach (var num in nums)
            {
                if (!dicitonary.ContainsKey(num)) dicitonary.Add(num, false);
                else dicitonary[num] = true;
            }

            return dicitonary.Keys.Where(k => dicitonary[k] == false).FirstOrDefault();
        }

        public static int SingleNumberUsingBitOperator(int[] nums)
        {
            var ans = 0;
            foreach (var num in nums) ans ^= num;
            return ans;
        }
    }
}
