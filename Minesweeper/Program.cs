using System.IO;
using System.Linq;

namespace Minesweeper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int fileIndex = 1; fileIndex < 3; fileIndex++)
            {

                MinesweeperCell[][] field = File.ReadLines($"feld{fileIndex}.txt")
                    .Select((l, i) => l.ToCharArray()
                                           .Select((s, j) => new MinesweeperCell { RowCoord = i, HasMine = s.Equals('*'), ColumnCoord = j })
                                           .ToArray())
                    .ToArray();

                for (int row = 0; row < field.Length; row++)
                {
                    for (int col = 0; col < field[row].Length; col++)
                    {
                        int mineCount = 0;
                        if (row > 0 && col > 0 && field[row - 1][col - 1].HasMine)
                        { mineCount++; }
                        if (col > 0 && field[row][col - 1].HasMine)
                        { mineCount++; }
                        if (col > 0 && row < field.Length - 1 && field[row + 1][col - 1].HasMine)
                        { mineCount++; }
                        if (row > 0 && field[row - 1][col].HasMine)
                        { mineCount++; }
                        if (row < field.Length - 1 && field[row + 1][col].HasMine)
                        { mineCount++; }
                        if (col < field[row].Length - 1 && row > 0 && field[row - 1][col + 1].HasMine)
                        { mineCount++; }
                        if (col < field[row].Length - 1 && field[row][col + 1].HasMine)
                        { mineCount++; }
                        if (col < field[row].Length - 1 && row < field.Length - 1 && field[row + 1][col + 1].HasMine)
                        { mineCount++; }
                        field[row][col].NeighbourMineCount = mineCount;
                    }
                }

                string result = string.Join("\n", field.Select(row => string.Concat(row.Select(col => col.HasMine ? "*" : col.NeighbourMineCount.ToString()))));
                File.WriteAllText($"feld{fileIndex}mogel.txt", result);
            }
        }
    }
}
