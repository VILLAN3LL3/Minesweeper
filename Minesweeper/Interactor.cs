using System.Collections.Generic;

namespace Minesweeper
{
    public class Interactor
    {
        private readonly CommandLineArg _fileArgs;
        private readonly FileProvider _fileProvider;
        private readonly MinesweeperFieldCreator _minesweeperFieldCreator;

        public Interactor(CommandLineArg fileArgs)
        {
            _fileArgs = fileArgs;
            _fileProvider = new FileProvider();
            _minesweeperFieldCreator = new MinesweeperFieldCreator();
        }

        public void CreateMogelzettel()
        {
            IEnumerable<string> inputFileLines = _fileProvider.ReadInputFileLines(_fileArgs.InputFilePath);
            MinesweeperField minesweeperField = _minesweeperFieldCreator.CreateMinesweeperField(inputFileLines);
            _fileProvider.WriteStringToFile(minesweeperField.ToString(), _fileArgs.OutputFilePath);
        }
    }
}
