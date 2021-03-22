using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace Minesweeper.Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private CommandLineArg subCommandLineArg;

        [SetUp]
        public void SetUp() => subCommandLineArg = new CommandLineArg("feld2.txt", "interactortests.txt");

        private Interactor CreateInteractor() => new Interactor(
                subCommandLineArg);

        [Test]
        public void Should_Create_Mogelzettel_File()
        {
            // Arrange
            Interactor interactor = CreateInteractor();
            var expectedResult = new string[] { "**100", "33200", "1*100" };

            // Act
            interactor.CreateMogelzettel();

            // Assert
            File.ReadAllLines("interactortests.txt").Should().BeEquivalentTo(expectedResult);
        }
    }
}
