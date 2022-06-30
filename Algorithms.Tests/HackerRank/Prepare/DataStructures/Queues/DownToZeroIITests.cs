using NUnit.Framework;
using System.Collections.Generic;
using DownToZeroII = Algorithms.HackerRank.Prepare.DataStructures.Queues.DownToZeroII;

namespace Algorithms.Tests.HackerRank.Prepare.DataStructures.Queues
{
    [TestFixture]
    public class DownToZeroIITests
    {
        private static IEnumerable<object> DownToZeroIITestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"2
3
4",
                ExpectedResult = @"3
3
",
                Message = "Sample Input"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"10
1
2
3
4
5
6
7
8
9
10",
                ExpectedResult = @"1
2
3
3
4
4
5
4
4
5
",
                Message = "My Case 1..10"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1
35",
                ExpectedResult = @"6
",
                Message = "My Case 35 => 5 * 7 => 1 + Steps(7) => 1 + 5 => 6"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1
36",
                ExpectedResult = @"5
",
                Message = "My Case 36 => 6 * 6 => 1 + Steps(6) => 1 + 4 => 5"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1
256",
                ExpectedResult = @"5
",
                Message = "My Case 256 => 16 * 16 => 1 + 4 * 4 => 2 + Steps(4) => 2 + 3 => 5"
            };
        }

        [TestCaseSource(nameof(DownToZeroIITestCases))]
        public void DownToZeroII_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            DownToZeroII.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
