
namespace LeetcodeExercises.Easy
{
    //Given an integer n, return a string array answer(1-indexed) where:
    //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    //answer[i] == "Fizz" if i is divisible by 3.
    //answer[i] == "Buzz" if i is divisible by 5.
    //answer[i] == i(as a string) if none of the above conditions are true.
    public static class Fizz_Buzz
    {
        public static IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();

            foreach (var digit in Enumerable.Range(1, n))
            {
                var text = "";

                if (digit % 3 != 0 && digit % 5 != 0) text += digit.ToString();
                if (digit % 3 == 0) text += "Fizz";
                if (digit % 5 == 0) text += "Buzz";

                result.Add(text);
            }

            return result;
        }
    }
}
