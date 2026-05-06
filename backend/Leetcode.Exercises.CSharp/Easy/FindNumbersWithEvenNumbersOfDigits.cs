
namespace LeetcodeExercises.Easy
{
    //Given an array nums of integers, return how many of them contain an even number of digits.
    public static class FindNumbersWithEvenNumbersOfDigits
    {
        public static int FindNumbers(int[] nums)
        {
            var count = 0;

            foreach (var number in nums)
            {
                if (number.ToString().Length % 2 == 0) count++;
            }

            return count;
        }

        //one liner
        public static int FindNumbersOneLiner(int[] nums)
        {
           return nums.Count(n => n.ToString().Length % 2 == 0);
        }
    }
}
