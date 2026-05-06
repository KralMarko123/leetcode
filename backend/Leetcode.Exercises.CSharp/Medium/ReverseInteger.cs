
namespace Leetcode.Exercises.CSharp.Medium
{
    //Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x / 10 == 0) return x;
            while (x % 10 == 0) x /= 10;

            var isNegative = x < 0;
            var xAsArray = isNegative ? x.ToString().Substring(1).ToCharArray() : x.ToString().ToCharArray();

            for (int i = 0; i < xAsArray.Length; i++)
            {
                if (i >= xAsArray.Length - 1 - i) break;

                var tmp = xAsArray[i];
                xAsArray[i] = xAsArray[xAsArray.Length - 1 - i];
                xAsArray[xAsArray.Length - 1 - i] = tmp;
            }

            if (!int.TryParse(string.Join("", xAsArray), out int value)) return 0;

            return isNegative ? int.Parse(string.Join("", xAsArray)) * -1 : int.Parse(string.Join("", xAsArray));
        }

        public static int ReverseUsingQueue(int x)
        {
            if (x / 10 == 0) return x;

            while (x % 10 == 0) x /= 10;

            var queue = new Queue<int>();
            bool isNegative = x < 0;
            int reversedInt = 0;

            while (x != 0)
            {
                queue.Enqueue(Math.Abs(x % 10));
                x /= 10;
            }

            if (!int.TryParse(string.Join("", queue), out int value)) return 0;

            while (queue.Count > 0) reversedInt = reversedInt * 10 + queue.Dequeue();

            return isNegative ? reversedInt * -1 : reversedInt;
        }
    }
}
