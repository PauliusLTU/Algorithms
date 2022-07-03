using NUnit.Framework;
using System.Collections.Generic;
using LargestRectangle = Algorithms.HackerRank.Prepare.DataStructures.Stacks.LargestRectangle;

namespace Algorithms.Tests.HackerRank.Prepare.DataStructures.Stacks
{
    [TestFixture]
    public class LargestRectangleTests
    {
        private static IEnumerable<object> LargestRectangleTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5
1 2 3 4 5",
                ExpectedResult = @"9
",
                Message = "Sample Input"
            };            
        }

        [TestCaseSource(nameof(LargestRectangleTestCases))]
        public void LargestRectangle_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            LargestRectangle.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
