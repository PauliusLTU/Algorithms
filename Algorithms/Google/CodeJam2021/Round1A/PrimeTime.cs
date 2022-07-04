using System;
using System.Collections.Generic;

namespace Algorithms.Google.CodeJam2021.Round1A.PrimeTime
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var num_test_cases = Convert.ToInt32(Console.ReadLine());
            for (var t = 0; t < num_test_cases; t++)
            {
                SolveProblem(t + 1);
            }
        }

        private static void SolveProblem(int testCaseNumber)
        {
            int m = Convert.ToInt32(Console.ReadLine());

            List<Tuple<int, int>> primes = new List<Tuple<int, int>>();
            long sumOfAllCards = 0;

            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int p = Convert.ToInt32(line[0]);
                int n = Convert.ToInt32(line[1]);
                primes.Add(new Tuple<int, int>(p, n));

                sumOfAllCards += p * n;
            }

            for (int sumOfProductElements = 2; sumOfProductElements <= 7000; sumOfProductElements++)
            {
                long product = sumOfAllCards - sumOfProductElements;
                if (product <= 1)
                {
                    break;
                }

                int runningSumOfProductElements = 0;

                foreach (Tuple<int, int> prime in primes)
                {
                    int p = prime.Item1;
                    int n = prime.Item2;

                    int cnt = 0;
                    while (product % p == 0)
                    {
                        product /= p;
                        cnt++;
                    }

                    if (cnt > n)
                    {
                        break;
                    }

                    runningSumOfProductElements += cnt * p;

                    if (product == 1 && runningSumOfProductElements == sumOfProductElements)
                    {
                        PrintResult(testCaseNumber, sumOfAllCards - sumOfProductElements);
                        return;
                    }
                }
            }

            PrintResult(testCaseNumber, 0);
        }

        private static void PrintResult(int testCaseNumber, long result)
        {
            Console.WriteLine("Case #{0}: {1}", testCaseNumber, result);
        }
    }
}
