using FluentAssertions;
using NUnit.Framework;

namespace Minesweeper.Tests
{
    [TestFixture]
    public class CommandLineTests
    {
        private CommandLine CreateCommandLine() => new CommandLine();

        [Test]
        public void Should_Create_CommandLineArgs_Object()
        {
            CommandLine commandLine = CreateCommandLine();
            string[] args = new[] { "input", "output" };
            var expectedResult = new CommandLineArg("input", "output");

            CommandLineArg result = commandLine.GetCommandLineArgs(
                args);

            result.Should().Be(expectedResult);
        }
    }
}
