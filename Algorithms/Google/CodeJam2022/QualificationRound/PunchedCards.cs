using System;
using System.Text;

namespace Algorithms.Google.CodeJam2022.QualificationRound.PunchedCards
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int num_test_cases = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < num_test_cases; t++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int[] parameters = Array.ConvertAll(line, int.Parse);
                SolveProblem(t + 1, parameters[0], parameters[1]);
            }
        }

        private static void SolveProblem(int num_test_case, int r, int c)
        {
            Console.WriteLine("Case #{0}:", num_test_case);

            string borderRow = GetRow(c, "+", "-");
            string dataRow = GetRow(c, "|", ".");

            string row = ".." + borderRow.Substring(2);
            Console.WriteLine(row);

            row = ".." + dataRow.Substring(2);
            Console.WriteLine(row);

            Console.WriteLine(borderRow);

            for (int i = 1; i < r; i++)
            {
                Console.WriteLine(dataRow);
                Console.WriteLine(borderRow);
            }
        }

        private static string GetRow(int c, string border, string cell)
        {
            cell = cell + border;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(border);
            for (int i = 0; i < c; i++)
            {
                stringBuilder.Append(cell);
            }

            return stringBuilder.ToString();
        }
    }
}
