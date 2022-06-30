using NUnit.Framework;
using System.Collections.Generic;
using HighestValuePalindrome = Algorithms.HackerRank.Prepare.Algorithms.Strings.HighestValuePalindrome;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Strings
{
    [TestFixture]
    public class HighestValuePalindromeTests
    {
        private static IEnumerable<object> HighestValuePalindromeTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"4 1
3943",
                ExpectedResult = @"3993
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"6 3
092282",
                ExpectedResult = @"992299
",
                Message = "Sample Input 1"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"4 1
0011",
                ExpectedResult = @"-1
",
                Message = "Sample Input 2"
            };
        }

        [TestCaseSource(nameof(HighestValuePalindromeTestCases))]
        public void HighestValuePalindrome_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            HighestValuePalindrome.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
