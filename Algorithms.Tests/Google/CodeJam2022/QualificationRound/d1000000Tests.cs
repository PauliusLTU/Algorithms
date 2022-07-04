using NUnit.Framework;
using System.Collections.Generic;
using d1000000 = Algorithms.Google.CodeJam2022.QualificationRound.d1000000;

namespace Algorithms.Tests.Google.CodeJam2022.QualificationRound
{
    [TestFixture]
    public class d1000000Tests
    {
        private static IEnumerable<object> d1000000TestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"4
4
6 10 12 8
6
5 4 5 4 4 4
10
10 10 7 6 7 4 4 5 7 4
1
10",
                ExpectedResult = @"Case #1: 4
Case #2: 5
Case #3: 9
Case #4: 1
",
                Message = "Sample Input"
            };
        }

        [TestCaseSource(nameof(d1000000TestCases))]
        public void d1000000_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            d1000000.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
