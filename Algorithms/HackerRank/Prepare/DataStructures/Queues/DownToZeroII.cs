using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms.HackerRank.Prepare.DataStructures.Queues.DownToZeroII
{
    class Result
    {

        /*
         * Complete the 'downToZero' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int downToZero(int n)
        {
            Queue<Number> queue = new Queue<Number>();

            queue.Enqueue(new Number(n, 0));

            while (queue.Count > 0)
            {
                Number current = queue.Dequeue();

                if (current.Value < 5)
                {
                    return current.Value == 4 ?
                        current.Depth + 3 :
                        current.Depth + current.Value;
                }

                queue.Enqueue(new Number(current.Value - 1, current.Depth + 1));

                int sqrt = (int)Math.Sqrt(current.Value);
                for (int i = sqrt; i > 1; i--)
                {
                    if (current.Value % i == 0)
                    {
                        int max = Math.Max(i, current.Value / i);
                        queue.Enqueue(new Number(max, current.Depth + 1));
                    }
                }
            }

            throw new NotImplementedException();
        }

        class Number
        {
            internal Number(int value, int depth)
            {
                Value = value;
                Depth = depth;
            }

            internal int Value { get; private set; }
            internal int Depth { get; private set; }
        }
    }

    public static class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = Result.downToZero(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
