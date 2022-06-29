﻿using Algorithms.HackerRank.Prepare.Algorithms.Greedy;
using Algorithms.Tests.Google;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Greedy
{
    [TestFixture]
    public class MinimumAbsoluteDifferenceTests
    {
        private static IEnumerable<object> MinimumAbsoluteDifferenceTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"3
3 -7 0",
                ExpectedResult = @"3
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"10
-59 -36 -13 1 -53 -92 -2 -96 -54 75",
                ExpectedResult = @"1
",
                Message = "Sample Input 1"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5
1 -3 71 68 17",
                ExpectedResult = @"3
",
                Message = "Sample Input 2"
            };
        }

        [TestCaseSourceAttribute(nameof(MinimumAbsoluteDifferenceTestCases))]
        public void MinimumAbsoluteDifference_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            MinimumAbsoluteDifference.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
