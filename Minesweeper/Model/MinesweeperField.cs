using System;
using System.Linq;

namespace Minesweeper
{
    public class MinesweeperField
    {
        public MinesweeperCell[][] Cells { get; set; } = Array.Empty<MinesweeperCell[]>();

        public override string ToString() => string.Join("\n", Cells?.Select(row => string.Concat(row.Select(col => col.HasMine ? "*" : col.NeighbourMineCount.ToString()))));
    }
}
