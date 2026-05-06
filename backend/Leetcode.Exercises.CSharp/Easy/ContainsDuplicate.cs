
namespace LeetcodeExercises.Easy
{
    //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    public static class Contains_Duplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var dictionary = new Dictionary<int, bool>();

            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num)) return true;
                else dictionary.Add(num, true);
            }

            return false;
        }

        public static bool ContainsDuplicateWithHashSet(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }
    }
}
