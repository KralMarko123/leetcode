
namespace Leetcode.Exercises.CSharp.Easy
{
    public static class MissingNumber
    {
        public static int FindMissingNumber(int[] nums)
        {
            // formula for the sum of a continuous range minus the actual sum gives us the odd one out
            return ((nums.Length + 1) * nums.Length / 2) - nums.Sum();
        }
    }
}
