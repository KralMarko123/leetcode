
namespace Leetcode.Exercises.CSharp.Medium
{
    // You are given an integer array height of length n.There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).
    // Find two lines that together with the x-axis form a container, such that the container contains the most water.
    // Return the maximum amount of water a container can store.
    //Notice that you may not slant the container.
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var maxArea = 0;
            var startingPoint = 0;
            var endPoint = height.Length - 1;

            while (endPoint != startingPoint)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[startingPoint], height[endPoint]) * (endPoint - startingPoint));
                if (height[startingPoint] > height[endPoint]) endPoint--;
                else startingPoint++;
            }


            return maxArea;
        }
    }
}
