namespace Leetcode.Exercises.CSharp.Easy
{
    // Given two integer arrays nums1 and nums2, return an array of their intersection.
    // Each element in the result must be unique and you may return the result in any order.
    public static class IntersectionOfTwoArrays
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var setOne = new HashSet<int>(nums1);
            var setTwo = new HashSet<int>(nums2);
            var result = new List<int>();

            foreach (var num in setTwo)
            {
                if (setOne.Contains(num)) result.Add(num);
            }

            return result.ToArray();
        }
    }
}
