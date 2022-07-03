using System;
using System.IO;

namespace Algorithms.HackerRank.Prepare.Algorithms.Implementation._3DSurfaceArea
{
    public class Solution
    {

        // Complete the surfaceArea function below.
        static int surfaceArea(int[][] A)
        {
            int a = 0;
            int rowCount = A.Length;
            int columnCount = A[0].Length;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < columnCount; c++)
                {
                    int h = A[r][c];
                    int p = c == 0 ? 0 : A[r][c - 1];
                    a += Math.Abs(h - p);
                }

                a += A[r][columnCount - 1];
            }

            for (int c = 0; c < columnCount; c++)
            {
                for (int r = 0; r < rowCount; r++)
                {
                    int h = A[r][c];
                    int p = r == 0 ? 0 : A[r - 1][c];
                    a += Math.Abs(h - p);
                }

                a += A[rowCount - 1][c];
            }

            return a + 2 * A.Length * A[0].Length;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] HW = Console.ReadLine().Split(' ');

            int H = Convert.ToInt32(HW[0]);

            int W = Convert.ToInt32(HW[1]);

            int[][] A = new int[H][];

            for (int i = 0; i < H; i++)
            {
                A[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
            }

            int result = surfaceArea(A);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
