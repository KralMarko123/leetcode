
namespace Leetcode.Exercises.CSharp.Easy
{
    // A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.
    // Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression. Otherwise, return false.
    public static class CanMakeArithmeticProgressionFromSequence
    {
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            // Step 1: Find min, max, and difference
            var minElement = arr.Min();
            var maxElement = arr.Max();
            var difference = (maxElement - minElement) / (arr.Length - 1);

            // Step 2: Check if difference can be equally distributed 
            if ((maxElement - minElement) % (arr.Length - 1) != 0) return false;

            // Step 3: Check if difference is zero meaning all elements are the same number
            if (difference == 0) return true;

            var set = new HashSet<int>();

            // Step 4: Check if each element is divisible by the difference and exists only once in the array
            foreach (var num in arr)
            {
                if ((num - minElement) % difference != 0 || set.Contains(num)) return false;

                set.Add(num);
            }

            return true;
        }
    }
}
