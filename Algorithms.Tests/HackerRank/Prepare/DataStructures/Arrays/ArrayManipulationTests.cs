using NUnit.Framework;
using System.Collections.Generic;
using ArrayManipulation = Algorithms.HackerRank.Prepare.DataStructures.Arrays.ArrayManipulation;

namespace Algorithms.Tests.HackerRank.Prepare.DataStructures.Arrays
{
    [TestFixture]
    public class ArrayManipulationTests
    {
        private static IEnumerable<object> ArrayManipulationTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"10 3
1 5 3
4 8 7
6 9 1",
                ExpectedResult = @"10
",
                Message = "Example"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5 3
1 2 100
2 5 100
3 4 100",
                ExpectedResult = @"200
",
                Message = "Sample Input"
            };
        }

        [TestCaseSource(nameof(ArrayManipulationTestCases))]
        public void ArrayManipulation_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            ArrayManipulation.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
