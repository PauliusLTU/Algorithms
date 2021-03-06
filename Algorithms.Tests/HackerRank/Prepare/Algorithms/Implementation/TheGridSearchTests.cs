using NUnit.Framework;
using System.Collections.Generic;
using TheGridSearch = Algorithms.HackerRank.Prepare.Algorithms.Implementation.TheGridSearch;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Implementation
{
    [TestFixture]
    public class MinimumLossTests
    {
        private static IEnumerable<object> TheGridSearchTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"2
10 10
7283455864
6731158619
8988242643
3830589324
2229505813
5633845374
6473530293
7053106601
0834282956
4607924137
3 4
9505
3845
3530
15 15
400453592126560
114213133098692
474386082879648
522356951189169
887109450487496
252802633388782
502771484966748
075975207693780
511799789562806
404007454272504
549043809916080
962410809534811
445893523733475
768705303214174
650629270887160
2 2
99
99",
                ExpectedResult = @"YES
NO
",
                Message = "Sample Input"
            };
        }

        [TestCaseSource(nameof(TheGridSearchTestCases))]
        public void TheGridSearch_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            TheGridSearch.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
