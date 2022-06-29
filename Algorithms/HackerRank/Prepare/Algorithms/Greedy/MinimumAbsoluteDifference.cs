using System;
using System.IO;
using System.Linq;

namespace Algorithms.HackerRank.Prepare.Algorithms.Greedy
{
    public static class MinimumAbsoluteDifference
    {
        // Complete the minimumAbsoluteDifference function below.
        private static int minimumAbsoluteDifference(int[] arr)
        {
            arr = arr.OrderBy(i => i).ToArray();

            int min = Math.Abs(arr[0] - arr[1]);

            for (int i = 1; i < arr.Length - 1; i++)
            {
                int c = Math.Abs(arr[i] - arr[i + 1]);
                if (c < min)
                {
                    min = c;
                }
            }

            return min;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = minimumAbsoluteDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
