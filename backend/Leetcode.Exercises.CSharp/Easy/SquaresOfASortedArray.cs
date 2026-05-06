
namespace LeetcodeExercises.Easy
{
    //Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
    public static class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            var result = nums.Select(n =>n*n).ToArray();
            Array.Sort(result);
            return result;
        }
    }
}
