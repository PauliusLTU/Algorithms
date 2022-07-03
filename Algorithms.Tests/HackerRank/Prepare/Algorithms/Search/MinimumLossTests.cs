using NUnit.Framework;
using System.Collections.Generic;
using MinimumLoss = Algorithms.HackerRank.Prepare.Algorithms.Search.MinimumLoss;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Search
{
    [TestFixture]
    public class MinimumLossTests
    {
        private static IEnumerable<object> MinimumLossTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"3
5 10 3",
                ExpectedResult = @"2
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5
20 7 8 2 5",
                ExpectedResult = @"2
",
                Message = "Sample Input 1"
            };
        }

        [TestCaseSource(nameof(MinimumLossTestCases))]
        public void MinimumLoss_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            MinimumLoss.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
