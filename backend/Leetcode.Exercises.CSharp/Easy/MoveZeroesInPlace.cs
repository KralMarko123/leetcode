namespace Leetcode.Exercises.CSharp.Easy
{
    // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    // Note that you must do this in-place without making a copy of the array.
    public static class MoveZeroesInPlace
    {
        public static void MoveZeroes(int[] nums)
        {
            var queue = new Queue<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) queue.Enqueue(i);
                else
                {
                    if (queue.Any())
                    {
                        nums[queue.Dequeue()] = nums[i];
                        nums[i] = 0;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}
