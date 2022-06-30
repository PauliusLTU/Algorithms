using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms.HackerRank.Prepare.Algorithms.Strings.HighestValuePalindrome
{
    class Result
    {

        /*
         * Complete the 'highestValuePalindrome' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER n
         *  3. INTEGER k
         */

        public static string highestValuePalindrome(string s, int n, int k)
        {
            int halfLength = s.Length / 2;

            char[] p1 = s.Substring(0, halfLength).ToArray();
            char[] p2 = s.Substring(s.Length - halfLength).Reverse().ToArray();
            char middle = s.Length % 2 != 0 ? s[halfLength] : ' ';

            int minChangesCount = GetMinChangesCount(p1, p2);
            if (k < minChangesCount)
            {
                return "-1";
            }

            int extraChangesCount = k - minChangesCount;
            return GetPolindrome(p1, middle, p2, extraChangesCount);
        }

        private static int GetMinChangesCount(char[] p1, char[] p2)
        {
            int count = 0;
            for (int i = 0; i < p1.Length; i++)
            {
                if (p1[i] != p2[i])
                {
                    count++;
                }
            }
            return count;
        }

        private static string GetPolindrome(char[] p1, char middle, char[] p2, int extraChangesCount)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                bool isEqual = p1[i] == p2[i];
                char max = p1[i] > p2[i] ? p1[i] : p2[i];

                // 8 = 8 -> 9 = 9
                if (isEqual && extraChangesCount > 1 && max != '9')
                {
                    p1[i] = p2[i] = '9';
                    extraChangesCount -= 2;
                }
                else if (!isEqual)
                {
                    // 1 != 9 -> 9 = 9
                    if (max == '9')
                    {
                        p1[i] = p2[i] = '9';
                    }
                    // 1 != 2 -> 9 = 9
                    else if (extraChangesCount > 0)
                    {
                        p1[i] = p2[i] = '9';
                        extraChangesCount--;
                    }
                    // 1 != 2 -> 2 = 2
                    else
                    {
                        p1[i] = p2[i] = max;
                    }
                }
            }

            if (middle != ' ' && extraChangesCount > 0)
            {
                middle = '9';
            }

            return Merge(p1, middle, p2);
        }

        private static string Merge(char[] p1, char middle, char[] p2)
        {
            var sb = new StringBuilder();

            sb.Append(p1);
            if (middle != ' ')
            {
                sb.Append(middle);
            }
            sb.Append(p2.Reverse().ToArray());

            return sb.ToString();
        }

    }

    public static class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            string s = Console.ReadLine();

            string result = Result.highestValuePalindrome(s, n, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
