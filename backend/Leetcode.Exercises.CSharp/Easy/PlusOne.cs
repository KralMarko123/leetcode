namespace Leetcode.Exercises.CSharp.Easy
{
    // You are given a large integer represented as an integer array digits,
    // where each digits[i] is the ith digit of the integer.The digits are ordered from most significant to least significant in left-to-right order.
    // The large integer does not contain any leading 0's.
    // Increment the large integer by one and return the resulting array of digits.
    public static class PlusOne
    {
        public static int[] AddPlusOne(int[] digits)
        {
            var result = new List<int>();
            var i = digits.Length - 1;
            var carryOver = false;

            while (i >= 0)
            {
                if (i == digits.Length - 1 || carryOver) digits[i]++;

                if (digits[i] == 10) carryOver = true;
                else carryOver = false;

                result = result.Prepend(digits[i] % 10).ToList();

                if(i == 0 && carryOver) result = result.Prepend(1).ToList();

                i--;
            }

            return result.ToArray();
        }
    }
}
