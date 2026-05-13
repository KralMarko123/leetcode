namespace Leetcode.Exercises.CSharp.Medium;

public static class DivideTwoIntegers
{
    public static int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        if (divisor == 1) return dividend;
        if (divisor == -1) return -dividend;

        long castDivident = Math.Abs((long)dividend);
        long castDivisor = Math.Abs((long)divisor);
        bool isNegative = (dividend < 0) ^ (divisor < 0);
        long result = 0;        
        
        
        while(castDivident >= castDivisor)  
        {
            castDivident -= castDivisor;
            result++;
        }

        return (int)(result * (isNegative ? -1 : 1));
    }
}