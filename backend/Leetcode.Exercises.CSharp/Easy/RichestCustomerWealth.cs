
namespace LeetcodeExercises.Easy
{
    //You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
    //A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.x
    public static class RichestCustomerWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            var maxWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                var wealth = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {
                    wealth += accounts[i][j];
                }

                if (wealth > maxWealth) maxWealth = wealth;
            }

            return maxWealth;
        }

        public static int MaximumWealthOneLiner(int[][] accounts)
        {
            return accounts.Max(a => a.Sum());
        }
    }
}
