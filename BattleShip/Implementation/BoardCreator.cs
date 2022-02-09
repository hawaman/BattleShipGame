using System;
using BattleShipGame.Interfaces;
using BattleShipGame.Models;
using BattleShipGame.Enums;

namespace BattleShipGame.Implementation
{
    public class BoardCreator : IBoardCreator
    {

        public Board CreateBoard(int rows, int columns)
        {
            try
            {
                // set all the board cell to unoccupied
                BoardCellStatus[,] statusArray = new BoardCellStatus[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        statusArray[i, j] = BoardCellStatus.Unoccupied;
                    }
                }

                return new Board
                {
                    BoardCellStatuses = statusArray,
                    Rows = rows,
                    Columns = columns
                };
       
            }
            catch (Exception ex)
            {
                throw new Exception($"Creating Board Failed : {ex.Message}");
            }
        }
    }
}
