using NUnit.Framework;
using System.Collections.Generic;
using BiggerIsGreater = Algorithms.HackerRank.Prepare.Algorithms.Implementation.BiggerIsGreater;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Implementation
{
    [TestFixture]
    public class BiggerIsGreaterTests
    {
        private static IEnumerable<object> BiggerIsGreaterTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1
dkhc",
                ExpectedResult = @"hcdk
",
                Message = "My Test Case"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5
ab
bb
hefg
dhck
dkhc",
                ExpectedResult = @"ba
no answer
hegf
dhkc
hcdk
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"6
lmno
dcba
dcbb
abdc
abcd
fedcbabcd",
                ExpectedResult = @"lmon
no answer
no answer
acbd
abdc
fedcbabdc
",
                Message = "Sample Input 1"
            };
        }

        [TestCaseSource(nameof(BiggerIsGreaterTestCases))]
        public void TheGridSearch_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            BiggerIsGreater.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
