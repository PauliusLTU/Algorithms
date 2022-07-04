using System;

namespace Algorithms.Google.CodeJam2022.QualificationRound.d1000000
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int num_test_cases = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < num_test_cases; t++)
            {
                SolveProblem(t + 1);
            }
        }

        private static void SolveProblem(int num_test_case)
        {
            Console.ReadLine();

            string[] line = Console.ReadLine().Split(' ');
            int[] sides = Array.ConvertAll(line, int.Parse);

            int length = GetMaxLength(sides);

            Console.WriteLine("Case #{0}: {1}", num_test_case, length);
        }

        private static int GetMaxLength(int[] sides)
        {
            Array.Sort(sides);

            int length = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                if (length < sides[i])
                {
                    length++;
                }
            }

            return length;
        }
    }
}
