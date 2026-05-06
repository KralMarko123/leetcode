
namespace Leetcode.Exercises.CSharp.Medium
{
    // Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
    // Notice that the solution set must not contain duplicate triplets.
    public static class ThreeSum
    {
        public static IList<IList<int>> FindThreeSum(int[] nums)
        {
            Array.Sort(nums);

            var result = new List<IList<int>>();

            if (nums[0] > 0) return result;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0) left++;
                    else right--;
                }
            }

            return result;
        }
    }
}
