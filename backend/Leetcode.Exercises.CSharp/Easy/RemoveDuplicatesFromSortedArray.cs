
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
    // The relative order of the elements should be kept the same.Then return the number of unique elements in nums.
    // Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
    // Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.The remaining elements of nums are not important as well as the size of nums.
    // Return k.
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // start from the second element
            var i = 1;

            // loop through each number
            foreach (var n in nums)
            {
                // if the number prior is not equal to the number now
                // it means that a new distinct number has been found
                // set that number to be at the latest position and increment to the new position
                if (nums[i - 1] != n)
                {
                    nums[i] = n;
                    i++;
                }
            }

            return i;
        }
    }

}
