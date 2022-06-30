using NUnit.Framework;
using System.Collections.Generic;
using FraudulentActivityNotifications = Algorithms.HackerRank.Prepare.Algorithms.Sorting.FraudulentActivityNotifications;

namespace Algorithms.Tests.HackerRank.Prepare.Algorithms.Sorting
{
    [TestFixture]
    public class FraudulentActivityNotificationsTests
    {
        private static IEnumerable<object> FraudulentActivityNotificationsTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"9 5
2 3 4 2 3 6 8 4 5",
                ExpectedResult = @"2
",
                Message = "Sample Input 0"
            };
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"5 4
1 2 3 4 4",
                ExpectedResult = @"0
",
                Message = "Sample Input 1"
            };
        }

        [TestCaseSource(nameof(FraudulentActivityNotificationsTestCases))]
        public void FraudulentActivityNotifications_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            FraudulentActivityNotifications.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
