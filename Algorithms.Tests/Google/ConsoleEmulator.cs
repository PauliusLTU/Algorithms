using NUnit.Framework;
using System;
using System.IO;

namespace Algorithms.Tests.Google
{
    internal static class ConsoleEmulator
    {
        private static StringWriter stringWriter = null;

        internal static void SetIn(ConsoleTestCase consoleTestCase)
        {
            StringReader stringReader = new StringReader(consoleTestCase.ConsoleInput);
            Console.SetIn(stringReader);

            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Console.SetError(stringWriter);
        }

        internal static void AreEqual(ConsoleTestCase consoleTestCase)
        {
            var actualResult = stringWriter.ToString();
            Assert.AreEqual(consoleTestCase.ExpectedResult, actualResult, consoleTestCase.Message);
        }
    }
}
