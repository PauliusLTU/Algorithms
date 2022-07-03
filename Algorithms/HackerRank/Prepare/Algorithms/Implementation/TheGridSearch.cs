using System;
using System.IO;

namespace Algorithms.HackerRank.Prepare.Algorithms.Implementation.TheGridSearch
{
    public class Solution
    {

        // Complete the gridSearch function below.
        static string gridSearch(string[] G, string[] P)
        {
            int gRowLength = G[0].Length;
            int pRowLength = P[0].Length;

            for (int i = 0; i <= G.Length - P.Length; i++)
            {
                for (int j = 0; j <= gRowLength - pRowLength; j++)
                {
                    bool isMathcing = true;

                    for (int r = 0; r < P.Length; r++)
                    {
                        if (!isMathcing)
                        {
                            break;
                        }

                        for (int c = 0; c < pRowLength; c++)
                        {
                            if (G[i + r][j + c] != P[r][c])
                            {
                                isMathcing = false;
                                break;
                            }
                        }
                    }

                    if (isMathcing)
                    {
                        return "YES";
                    }
                }
            }

            return "NO";
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] RC = Console.ReadLine().Split(' ');

                int R = Convert.ToInt32(RC[0]);

                int C = Convert.ToInt32(RC[1]);

                string[] G = new string[R];

                for (int i = 0; i < R; i++)
                {
                    string GItem = Console.ReadLine();
                    G[i] = GItem;
                }

                string[] rc = Console.ReadLine().Split(' ');

                int r = Convert.ToInt32(rc[0]);

                int c = Convert.ToInt32(rc[1]);

                string[] P = new string[r];

                for (int i = 0; i < r; i++)
                {
                    string PItem = Console.ReadLine();
                    P[i] = PItem;
                }

                string result = gridSearch(G, P);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
