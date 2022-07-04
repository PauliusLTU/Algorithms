using System;
using System.Linq;

namespace Algorithms.Google.CodeJam2022.QualificationRound._3DPrinting
{
    public class Solution
    {
        private const int ImageSize = 1000000;

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
            int[] cartriges = new int[4] { ImageSize, ImageSize, ImageSize, ImageSize };
            ReadMinCartriges(cartriges);

            int image = ImageSize;
            int[] cartrigesUsed = new int[4];
            for (int i = 0; i < cartriges.Length; i++)
            {
                int cartrigeUsed = Math.Min(image, cartriges[i]);
                image -= cartrigeUsed;
                cartrigesUsed[i] = cartrigeUsed;
            }

            string result = String.Format("Case #{0}: ", num_test_case);
            if (image == 0)
            {
                Console.WriteLine(result + String.Join(" ", cartrigesUsed.Select(c => c.ToString())));
                return;
            }

            Console.WriteLine(result + "IMPOSSIBLE");
        }

        private static void ReadMinCartriges(int[] cartriges)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int[] parameters = Array.ConvertAll(line, int.Parse);

                for (int j = 0; j < parameters.Length; j++)
                {
                    cartriges[j] = Math.Min(cartriges[j], parameters[j]);
                }
            }
        }
    }
}
