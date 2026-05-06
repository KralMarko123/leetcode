
namespace LeetcodeExercises.Easy
{
    //Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
    //Return the running sum of nums.
    public static class SumOf1DArray
    {
        public static int[] RunningSum(int[] nums)
        {
            var sum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums;
        }

        public static int[] RunningSum(List<int> nums)
        {
            var sum = 0;

            for (var i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums.ToArray();
        }

    }
}
