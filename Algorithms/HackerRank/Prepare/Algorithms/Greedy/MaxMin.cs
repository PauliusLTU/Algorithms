using System;
using System.IO;
using System.Linq;

namespace Algorithms.HackerRank.Prepare.Algorithms.Greedy
{
    public static class MaxMin
    {
        // Complete the maxMin function below.
        private static int maxMin(int k, int[] arr)
        {
            arr = arr.OrderBy(i => i).ToArray();

            int min = arr[k - 1] - arr[0];

            for (int i = 1; i < arr.Length - k + 1; i++)
            {
                int d = arr[i + k - 1] - arr[i];
                if (d < min)
                {
                    min = d;
                }
            }

            return min;
        }

        public static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("OUTPUT_PATH", @"e:\Dev\Algorithms\Algorithms\bin\Debug\netcoreapp3.1\output.txt");
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            int result = maxMin(k, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
