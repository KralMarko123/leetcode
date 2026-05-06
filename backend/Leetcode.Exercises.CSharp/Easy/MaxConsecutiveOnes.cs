
namespace LeetcodeExercises.Easy
{
    //Given a binary array nums, return the maximum number of consecutive 1's in the array.
    public static class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            var maxConsecutiveOnes = 0;
            var consecutiveOnes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    consecutiveOnes++;
                    maxConsecutiveOnes = maxConsecutiveOnes > consecutiveOnes ? maxConsecutiveOnes : consecutiveOnes;
                }
                else consecutiveOnes = 0;
            }

            return maxConsecutiveOnes;
        }
    }
}
