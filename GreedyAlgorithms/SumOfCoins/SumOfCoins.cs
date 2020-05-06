namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
            var targetSum = 923;

            var selectedCoins = ChooseCoins(availableCoins, targetSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {

            Dictionary<int, int> kvp = new Dictionary<int, int>();

            coins = coins.OrderByDescending(x => x).ToList();


            // currentCoin is index
            int currentCoin = 0;
            int currentSum = 0;

            while (currentSum < targetSum && currentCoin < coins.Count)
            {
                int coin = coins[currentCoin];
                if(currentSum + coin > targetSum)
                {
                    currentCoin++;
                    continue;
                }

                kvp[coin] = (targetSum - currentSum) / coin;

                currentSum += (coin * kvp[coin]);
            }


            if(currentSum != targetSum)
            {
                throw new InvalidOperationException("some error");
            }

            // TODO
            return kvp;
        }
    }
}