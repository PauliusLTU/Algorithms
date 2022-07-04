using NUnit.Framework;
using System.Collections.Generic;
using ChainReactions = Algorithms.Google.CodeJam2022.QualificationRound.ChainReactions;

namespace Algorithms.Tests.Google.CodeJam2022.QualificationRound
{
    [TestFixture]
    public class ChainReactionsTests
    {
        private static IEnumerable<object> ChainReactionsTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"3
4
60 20 40 50
0 1 1 2
5
3 2 1 4 5
0 1 1 1 0
8
100 100 100 90 80 100 90 100
0 1 2 1 2 3 1 3",
                ExpectedResult = @"Case #1: 110
Case #2: 14
Case #3: 490
",
                Message = "Sample Input"
            };
        }

        [TestCaseSource(nameof(ChainReactionsTestCases))]
        public void ChainReactions_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            ChainReactions.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
