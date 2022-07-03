using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms.HackerRank.Prepare.DataStructures.Stacks.LargestRectangle
{
    public class Solution
    {

        // Complete the largestRectangle function below.
        static long largestRectangle(int[] h)
        {
            Stack<int> houseStack = new Stack<int>();
            int i = 0, maxArea = 0;

            while (i < h.Length)
            {
                if (houseStack.Count == 0 || h[houseStack.Peek()] <= h[i])
                {
                    houseStack.Push(i++);
                }
                else
                {
                    Pop();
                }
            }

            while (houseStack.Count > 0)
            {
                Pop();
            }

            void Pop()
            {
                int hi = houseStack.Pop();
                int length = (houseStack.Count == 0 ? i : i - houseStack.Peek() - 1);
                int area = h[hi] * length;
                if (area > maxArea)
                {
                    maxArea = area;
                }
            }

            return maxArea;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            long result = largestRectangle(h);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
