
namespace Leetcode.Exercises.CSharp.Hard
{
    // Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    // The overall run time complexity should be O(log (m+n)).
    public static class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0, k = 0;
            int[] mergedArray = new int[nums1.Length + nums2.Length];

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j]) mergedArray[k++] = nums1[i++];
                else mergedArray[k++] = nums2[j++];
            }

            while (i < nums1.Length) mergedArray[k++] = nums1[i++];
            while (j < nums2.Length) mergedArray[k++] = nums2[j++];

            int length = mergedArray.Length - 1;

            return mergedArray.Length % 2 == 0 ?
                (double)(mergedArray[length / 2] + mergedArray[(length / 2) + 1]) / 2
                : mergedArray[length / 2];
        }
    }
}
