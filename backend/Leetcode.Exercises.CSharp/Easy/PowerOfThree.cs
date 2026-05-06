
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given an integer n, return true if it is a power of three.Otherwise, return false.
    // An integer n is a power of three, if there exists an integer x such that n == 3x.
    public static class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n == 1) return true;
            if (n <= 0) return false;

            // start from the number and work your way down unti less than 1
            // if the number is undividable by 3 at any point return false
            while (n > 1)
            {
                if (n % 3 != 0) return false;

                n /= 3;
            }

            return true;
        }
    }
}
