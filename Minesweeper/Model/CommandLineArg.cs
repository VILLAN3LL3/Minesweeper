namespace Minesweeper
{
    public record CommandLineArg
    {
        public CommandLineArg(string inputFilePath, string outputFilePath) => (InputFilePath, OutputFilePath) = (inputFilePath, outputFilePath);

        public string InputFilePath { get; }
        public string OutputFilePath { get; }
    }
}
