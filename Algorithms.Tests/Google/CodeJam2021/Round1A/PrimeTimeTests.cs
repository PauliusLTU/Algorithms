using Algorithms.Google.CodeJam2021.Round1A;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests.Google.CodeJam2021.Round1A
{
    [TestFixture]
    public class PrimeTimeTests
    {
        private static IEnumerable<object> PrimeTimeTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1
3
2 6
3 2
5 1
",
                ExpectedResult = @"Case #1: 15
",
                Message = "My Case"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1
5
2 2
3 1
5 2
7 1
11 1
",
                ExpectedResult = @"Case #1: 25
",
                Message = "Sample Case #1"
            };
            yield return new ConsoleTestCase() 
            {
                ConsoleInput = @"4
5
2 2
3 1
5 2
7 1
11 1
1
17 2
2
2 2
3 1
1
2 7",
                ExpectedResult = @"Case #1: 25
Case #2: 17
Case #3: 0
Case #4: 8
",
                Message = "Sample"
            };
        }

        [TestCaseSourceAttribute(nameof(PrimeTimeTestCases))]
        public void PrimeTime_Solve_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            PrimeTime.Solve();

            //Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
