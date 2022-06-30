using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms.HackerRank.Prepare.Algorithms.Sorting.FraudulentActivityNotifications
{
    class Result
    {

        /*
         * Complete the 'activityNotifications' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY expenditure
         *  2. INTEGER d
         */

        public static int activityNotifications(List<int> expenditure, int d)
        {
            int notifications = 0;

            SortedList history = new SortedList(d, expenditure.Take(d));
            for (int i = d; i < expenditure.Count; i++)
            {
                int c = expenditure[i];

                if (c >= history.Median * 2)
                {
                    notifications++;
                }

                history.Remove(expenditure[i - d]);
                history.Add(c);
            }

            return notifications;
        }

        internal class SortedList
        {
            private const int ExpenditureMaxValue = 200;
            private int[] values = new int[ExpenditureMaxValue + 1];

            internal SortedList(int dayCount, IEnumerable<int> values)
            {
                DayCount = dayCount;
                IsDayCountEven = dayCount % 2 == 0;
                MiddleIndex = dayCount / 2 + (IsDayCountEven ? 0 : 1);

                foreach (var value in values)
                {
                    Add(value);
                }
            }

            internal void Add(int value)
            {
                values[value]++;
            }

            internal void Remove(int value)
            {
                values[value]--;
            }

            private decimal GetMedian()
            {
                int c = 0;
                for (int i = 0; i <= ExpenditureMaxValue; i++)
                {
                    c += values[i];
                    if (c >= MiddleIndex)
                    {
                        if (IsDayCountEven)
                        {
                            if (c > MiddleIndex)
                            {
                                return i;
                            }
                            else
                            {
                                for (int j = i + 1; j <= ExpenditureMaxValue; j++)
                                {
                                    c += values[j];
                                    if (c > MiddleIndex)
                                    {
                                        return (i + j) / 2.0m;
                                    }
                                }
                            }
                        }
                        else
                        {
                            return i;
                        }
                    }
                }

                throw new NotImplementedException();
            }

            private int DayCount { get; set; }

            private bool IsDayCountEven { get; set; }

            private int MiddleIndex { get; set; }

            internal decimal Median => GetMedian();
        }
    }

    public static class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

            int result = Result.activityNotifications(expenditure, d);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
