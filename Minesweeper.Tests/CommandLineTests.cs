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
            // Arrange
            CommandLine commandLine = CreateCommandLine();
            string[] args = new[] { "input.txt", "output.txt" };
            var expectedResult = new CommandLineArg("input.txt", "output.txt");

            // Act
            CommandLineArg result = commandLine.GetCommandLineArgs(
                args);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
