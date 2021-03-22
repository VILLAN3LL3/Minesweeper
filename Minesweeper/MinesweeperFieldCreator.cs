using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
    public class MinesweeperFieldCreator
    {
        public MinesweeperField CreateMinesweeperField(IEnumerable<string> textLines)
        {
            MinesweeperCell[][] cells = textLines
                    .Select((l, i) => l.ToCharArray()
                                           .Select((s, j) => new MinesweeperCell { RowCoord = i, HasMine = s.Equals('*'), ColumnCoord = j })
                                           .ToArray())
                    .ToArray();

            for (int row = 0; row < cells.Length; row++)
            {
                for (int col = 0; col < cells[row].Length; col++)
                {
                    int mineCount = 0;
                    if (row > 0 && col > 0 && cells[row - 1][col - 1].HasMine)
                    { mineCount++; }
                    if (col > 0 && cells[row][col - 1].HasMine)
                    { mineCount++; }
                    if (col > 0 && row < cells.Length - 1 && cells[row + 1][col - 1].HasMine)
                    { mineCount++; }
                    if (row > 0 && cells[row - 1][col].HasMine)
                    { mineCount++; }
                    if (row < cells.Length - 1 && cells[row + 1][col].HasMine)
                    { mineCount++; }
                    if (col < cells[row].Length - 1 && row > 0 && cells[row - 1][col + 1].HasMine)
                    { mineCount++; }
                    if (col < cells[row].Length - 1 && cells[row][col + 1].HasMine)
                    { mineCount++; }
                    if (col < cells[row].Length - 1 && row < cells.Length - 1 && cells[row + 1][col + 1].HasMine)
                    { mineCount++; }
                    cells[row][col].NeighbourMineCount = mineCount;
                }
            }

            return new MinesweeperField() { Cells = cells };
        }
    }
}
