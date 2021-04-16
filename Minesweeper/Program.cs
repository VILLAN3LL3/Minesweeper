namespace Minesweeper
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var commandLine = new CommandLine();
            var interactor = new Interactor();

            CommandLineArg fileArgs = commandLine.GetCommandLineArgs(args);
            interactor.CreateMogelzettel(fileArgs);
        }
    }
}
