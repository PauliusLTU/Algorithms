using System;
using System.IO;

namespace Algorithms.HackerRank.Prepare.Algorithms.Implementation.BiggerIsGreater
{
    class Result
    {
        private const string NoAnswer = "no answer";

        /*
         * Complete the 'biggerIsGreater' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING w as parameter.
         */

        public static string biggerIsGreater(string w)
        {
            if (w.Length < 2)
            {
                return NoAnswer;
            }

            int lastIndexOfAscChar = GetLastIndexOfAscChar(w);
            if (lastIndexOfAscChar == -1)
            {
                return NoAnswer;
            }

            int lastIndexOfBiggerChar = LastIndexOfBiggerChar(w, lastIndexOfAscChar);

            char[] word = w.ToCharArray();
            
            char temp = word[lastIndexOfAscChar];
            word[lastIndexOfAscChar] = word[lastIndexOfBiggerChar];
            word[lastIndexOfBiggerChar] = temp;

            Reverse(word.AsSpan(lastIndexOfAscChar + 1));

            return new string(word);
        }

        private static int GetLastIndexOfAscChar(string w)
        {
            int i = w.Length - 1;

            while(i > 0)
            {
                if (w[i - 1] < w[i])
                {
                    return i - 1;
                }

                i--;
            }

            return -1;
        }

        private static int LastIndexOfBiggerChar(string w, int lastIndexOfAscChar)
        {
            char ascChar = w[lastIndexOfAscChar];

            for (int i = w.Length - 1; i > lastIndexOfAscChar; i--)
            {
                if (ascChar < w[i])
                {
                    return i;
                }
            }

            return -1;
        }

        private static void Reverse(Span<char> w)
        { 
            int m = w.Length / 2;
            for(int i = 0; i < m; i++)
            {
                char temp = w[i];
                w[i] = w[^(i + 1)];
                w[^(i + 1)] = temp;
            }
        }
    }

    public class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();

                string result = Result.biggerIsGreater(w);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
