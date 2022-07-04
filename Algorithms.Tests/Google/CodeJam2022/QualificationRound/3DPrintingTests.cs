using NUnit.Framework;
using System.Collections.Generic;
using _3DPrinting = Algorithms.Google.CodeJam2022.QualificationRound._3DPrinting;

namespace Algorithms.Tests.Google.CodeJam2022.QualificationRound
{
    [TestFixture]
    public class _3DPrintingTests
    {
        private static IEnumerable<object> _3DPrintingTestCases()
        {
            yield return new ConsoleTestCase()
            {
                ConsoleInput = @"3
300000 200000 300000 500000
300000 200000 500000 300000
300000 500000 300000 200000
1000000 1000000 0 0
0 1000000 1000000 1000000
999999 999999 999999 999999
768763 148041 178147 984173
699508 515362 534729 714381
949704 625054 946212 951187",
                ExpectedResult = @"Case #1: 300000 200000 300000 200000
Case #2: IMPOSSIBLE
Case #3: 699508 148041 152451 0
",
                Message = "Sample Input"
            };
        }

        [TestCaseSource(nameof(_3DPrintingTestCases))]
        public void _3DPrinting_Solution_Main_Tests(ConsoleTestCase consoleTestCase)
        {
            // Arrange
            ConsoleEmulator.SetIn(consoleTestCase);

            // Act
            _3DPrinting.Solution.Main(null);

            // Assert
            ConsoleEmulator.AreEqual(consoleTestCase);
        }
    }
}
