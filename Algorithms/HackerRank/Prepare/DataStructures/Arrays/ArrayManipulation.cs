using System;
using System.IO;

namespace Algorithms.HackerRank.Prepare.DataStructures.Arrays.ArrayManipulation
{
    public class Solution
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] r = new long[n];

            foreach (int[] query in queries)
            {
                int a = query[0];
                int b = query[1];
                int k = query[2];

                r[a - 1] += k;
                if (b < n)
                {
                    r[b] -= k;
                }
            }

            long max = 0;
            long c = 0;
            for (int i = 0; i < n; i++)
            {
                c += r[i];
                if (max < c)
                {
                    max = c;
                }
            }

            return max;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
