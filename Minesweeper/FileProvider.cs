using System.Collections.Generic;
using System.IO;

namespace Minesweeper
{
    public class FileProvider
    {
        public IEnumerable<string> ReadInputFileLines(string inputFilePath) => File.ReadLines(inputFilePath);
        public void WriteStringToFile(string text, string outputFilePath) => File.WriteAllText(outputFilePath, text);
    }
}
