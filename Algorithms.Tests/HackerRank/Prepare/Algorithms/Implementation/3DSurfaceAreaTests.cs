using NUnit.Framework;
using System.Collections.Generic;
using _3DSurfaceArea = Algorithms.HackerRank.Prepare.Algorithms.Implementation._3DSurfaceArea;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Implementation
{
    [TestFixture]
    public class _3DSurfaceAreaTests
    {
        private static IEnumerable<object> _3DSurfaceAreaTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"1 1
1",
                ExpectedResult = @"6
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"3 3
1 3 4
2 2 3
1 2 4",
                ExpectedResult = @"60
",
                Message = "Sample Input 1"
            };
        }

        [TestCaseSource(nameof(_3DSurfaceAreaTestCases))]
        public void _3DSurfaceArea_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            _3DSurfaceArea.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
