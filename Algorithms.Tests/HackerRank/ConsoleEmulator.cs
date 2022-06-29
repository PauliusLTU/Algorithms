using Algorithms.Tests.Google;
using NUnit.Framework;
using System;
using System.IO;

namespace Algorithms.Tests.HackerRank
{
    internal static class ConsoleEmulator
    {
        private static readonly string OutputPath = @"e:\Dev\Algorithms\Algorithms\bin\Debug\netcoreapp3.1\output.txt";

        internal static void SetIn(ConsoleTestCase consoleTestCase)
        {
            Environment.SetEnvironmentVariable("OUTPUT_PATH", OutputPath);
            File.Delete(OutputPath);

            StringReader stringReader = new StringReader(consoleTestCase.ConsoleInput);
            Console.SetIn(stringReader);
        }

        internal static void AreEqual(ConsoleTestCase consoleTestCase)
        {
            var actualResult = File.ReadAllText(OutputPath);
            Assert.AreEqual(consoleTestCase.ExpectedResult, actualResult, consoleTestCase.Message);
        }
    }
}
