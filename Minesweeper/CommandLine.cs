namespace Minesweeper
{
    public class CommandLine
    {
        public CommandLineArg GetCommandLineArgs(string[] args) => new CommandLineArg(GetInputFilePath(args), GetOutputFilePath(args));

        private string GetInputFilePath(string[] args) => args[0];

        private string GetOutputFilePath(string[] args) => args[1];
    }
}
