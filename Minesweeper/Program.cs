namespace Minesweeper
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var commandLine = new CommandLine();
            CommandLineArg fileArgs = commandLine.GetCommandLineArgs(args);

            var interactor = new Interactor(fileArgs);
            interactor.CreateMogelzettel();
        }
    }
}
