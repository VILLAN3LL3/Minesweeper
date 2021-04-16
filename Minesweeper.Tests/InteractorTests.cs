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
        public void SetUp() => subCommandLineArg = new CommandLineArg(
            "feld2.txt",
            "interactortests.txt");

        private Interactor CreateInteractor() => new Interactor();

        [Test]
        public void Should_Create_Mogelzettel_File()
        {
            Interactor interactor = CreateInteractor();
            string[] expectedResult = new string[] { "**100", "33200", "1*100" };

            interactor.CreateMogelzettel(
                subCommandLineArg);

            File.ReadAllLines("interactortests.txt").Should().BeEquivalentTo(expectedResult);
        }
    }
}
