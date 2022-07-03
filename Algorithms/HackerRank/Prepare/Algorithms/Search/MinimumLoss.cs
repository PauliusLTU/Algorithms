using System;
using System.IO;
using System.Linq;

namespace Algorithms.HackerRank.Prepare.Algorithms.Search.MinimumLoss
{
    public class Solution
    {

        // Complete the minimumLoss function below.
        static int minimumLoss(long[] price)
        {
            var orderedPrices = price
                .Select((p, i) => new { Price = p, Index = i })
                .OrderByDescending(p => p.Price)
                .ToArray();

            long? minLoss = null;
            for (int i = 0; i < orderedPrices.Length - 1; i++)
            {
                for (int j = i + 1; j < orderedPrices.Length; j++)
                {
                    if (orderedPrices[i].Index < orderedPrices[j].Index)
                    {
                        long diff = orderedPrices[i].Price - orderedPrices[j].Price;
                        if (diff > 0 && (minLoss is null || diff < minLoss))
                        {
                            minLoss = diff;
                        }
                        break;
                    }
                }
            }

            return (int)minLoss;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            long[] price = Array.ConvertAll(Console.ReadLine().Split(' '), priceTemp => Convert.ToInt64(priceTemp))
            ;
            int result = minimumLoss(price);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
