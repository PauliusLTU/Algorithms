using NUnit.Framework;
using System.Collections.Generic;
using MaxMin = Algorithms.HackerRank.Prepare.Algorithms.Greedy.MaxMin;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Greedy
{
    [TestFixture]
    public class MaxMinTests
    {
        private static IEnumerable<object> MaxMinTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"7
3
10
100
300
200
1000
20
30",
                ExpectedResult = @"20
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"10
4
1
2
3
4
10
20
30
40
100
200",
                ExpectedResult = @"3
",
                Message = "Sample Input 1"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5
2
1
2
1
2
1",
                ExpectedResult = @"0
",
                Message = "Sample Input 2"
            };
        }

        [TestCaseSource(nameof(MaxMinTestCases))]
        public void MaxMin_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            MaxMin.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
