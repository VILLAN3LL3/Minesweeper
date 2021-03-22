using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace Minesweeper.Tests
{
    [TestFixture]
    public class FileProviderTests
    {
        private FileProvider CreateProvider() => new FileProvider();

        [Test]
        public void Should_Read_Input_File_Lines()
        {
            // Arrange
            FileProvider provider = CreateProvider();
            string inputFilePath = "feld2.txt";
            string[] expectedResult = new string[] { "**...", ".....", ".*..." };

            // Act
            IEnumerable<string> result = provider.ReadInputFileLines(
                inputFilePath);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Should_Write_Text_To_Output_File()
        {
            // Arrange
            FileProvider provider = CreateProvider();
            string text = "Line1\nLine2\nLine3";
            string outputFilePath = "FileProviderTest.txt";
            try
            {
                File.Delete(outputFilePath);
            }
            catch (System.Exception ex)
            {
                // do nothing
            }

            // Act
            provider.WriteStringToFile(
                text,
                outputFilePath);

            // Assert
            File.ReadAllText(outputFilePath).Should().Be(text);
        }
    }
}
