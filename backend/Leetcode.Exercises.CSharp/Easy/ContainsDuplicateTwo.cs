namespace Leetcode.Exercises.CSharp.Easy
{
    //Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
    public static class ContainsDuplicateTwo
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && (i - dict[nums[i]]) <= k) return true;
                else dict[nums[i]] = i;
            }

            return false;
        }
    }
}
