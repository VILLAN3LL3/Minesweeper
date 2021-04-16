using System.Collections.Generic;

namespace Minesweeper
{
    public class Interactor
    {
        private readonly FileProvider _fileProvider;
        private readonly MinesweeperFieldCreator _minesweeperFieldCreator;

        public Interactor() // Lieber als Parameter in die CreateMogelzettel übergeben
        {
            _fileProvider = new FileProvider();
            _minesweeperFieldCreator = new MinesweeperFieldCreator();
        }

        public void CreateMogelzettel(CommandLineArg fileArgs)
        {
            IEnumerable<string> inputFileLines = _fileProvider.ReadInputFileLines(fileArgs.InputFilePath);
            MinesweeperField minesweeperField = _minesweeperFieldCreator.CreateMinesweeperField(inputFileLines);
            _fileProvider.WriteStringToFile(minesweeperField.ToString(), fileArgs.OutputFilePath);
        }
    }
}
