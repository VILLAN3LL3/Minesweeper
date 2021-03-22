namespace Minesweeper
{
    public class MinesweeperCell
    {
        public int ColumnCoord { get; set; }
        public int RowCoord { get; set; }
        public bool HasMine { get; set; }
        public int NeighbourMineCount { get; set; }
    }
}
