
namespace LeetcodeExercises.Easy
{
    //Given an integer num, return the number of steps to reduce it to zero.
    //In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
    public static class NumberOfStepsToReduceToZero
    {
        public static int NumberOfSteps(int num)
        {
            var numberOfSteps = 0;

            while (num != 0)
            {
                if (num % 2 == 0) num /= 2;
                else num--;

                numberOfSteps++;
            }

            return numberOfSteps;
        }
    }
}