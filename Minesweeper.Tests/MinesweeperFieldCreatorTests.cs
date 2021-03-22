using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Minesweeper.Tests
{
    [TestFixture]
    public class MinesweeperFieldCreatorTests
    {


        [SetUp]
        public void SetUp()
        {

        }

        private MinesweeperFieldCreator CreateMinesweeperFieldCreator() => new MinesweeperFieldCreator();

        [Test]
        public void Should_Create_Minesweeper_Field()
        {
            // Arrange
            MinesweeperFieldCreator minesweeperFieldCreator = CreateMinesweeperFieldCreator();
            IEnumerable<string> textLines = new string[] { "**...", ".....", ".*..." };
            var expectedResult = new MinesweeperField();
            expectedResult.Cells = new MinesweeperCell[][]
            {
                new MinesweeperCell[]
                {
                    new MinesweeperCell { ColumnCoord = 0, RowCoord = 0, HasMine = true, NeighbourMineCount = 1 },
                    new MinesweeperCell { ColumnCoord = 1, RowCoord = 0, HasMine = true, NeighbourMineCount = 1 },
                    new MinesweeperCell { ColumnCoord = 2, RowCoord = 0, HasMine = false, NeighbourMineCount = 1 },
                    new MinesweeperCell { ColumnCoord = 3, RowCoord = 0, HasMine = false, NeighbourMineCount = 0 },
                    new MinesweeperCell { ColumnCoord = 4, RowCoord = 0, HasMine = false, NeighbourMineCount = 0 }
                },
                new MinesweeperCell[]
                {
                    new MinesweeperCell { ColumnCoord = 0, RowCoord = 1, HasMine = false, NeighbourMineCount = 3 },
                    new MinesweeperCell { ColumnCoord = 1, RowCoord = 1, HasMine = false, NeighbourMineCount = 3 },
                    new MinesweeperCell { ColumnCoord = 2, RowCoord = 1, HasMine = false, NeighbourMineCount = 2 },
                    new MinesweeperCell { ColumnCoord = 3, RowCoord = 1, HasMine = false, NeighbourMineCount = 0 },
                    new MinesweeperCell { ColumnCoord = 4, RowCoord = 1, HasMine = false, NeighbourMineCount = 0 }
                },
                new MinesweeperCell[]
                {
                    new MinesweeperCell { ColumnCoord = 0, RowCoord = 2, HasMine = false, NeighbourMineCount = 1 },
                    new MinesweeperCell { ColumnCoord = 1, RowCoord = 2, HasMine = true, NeighbourMineCount = 0 },
                    new MinesweeperCell { ColumnCoord = 2, RowCoord = 2, HasMine = false, NeighbourMineCount = 1 },
                    new MinesweeperCell { ColumnCoord = 3, RowCoord = 2, HasMine = false, NeighbourMineCount = 0 },
                    new MinesweeperCell { ColumnCoord = 4, RowCoord = 2, HasMine = false, NeighbourMineCount = 0 }
                }
            };

            // Act
            MinesweeperField result = minesweeperFieldCreator.CreateMinesweeperField(
                textLines);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
