using NUnit.Framework;
using System.Collections.Generic;
using PunchedCards = Algorithms.Google.CodeJam2022.QualificationRound.PunchedCards;

namespace Algorithms.Tests.Google.CodeJam2022.QualificationRound
{
    [TestFixture]
    public class PunchedCardsTests
    {
        private static IEnumerable<object> PunchedCardsTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"3
3 4
2 2
2 3",
                ExpectedResult = @"Case #1:
..+-+-+-+
..|.|.|.|
+-+-+-+-+
|.|.|.|.|
+-+-+-+-+
|.|.|.|.|
+-+-+-+-+
Case #2:
..+-+
..|.|
+-+-+
|.|.|
+-+-+
Case #3:
..+-+-+
..|.|.|
+-+-+-+
|.|.|.|
+-+-+-+
",
                Message = "Sample Input"
            };
        }

        [TestCaseSource(nameof(PunchedCardsTestCases))]
        public void PunchedCards_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            PunchedCards.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
