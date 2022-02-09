using System;
using BattleShipGame.Enums;
using BattleShipGame.Interfaces;
using BattleShipGame.Models;

namespace BattleShipGame.Implementation
{
    public class Attacker : IAttacker
    {
        public AttackStatus Attack(Board board, int row, int column)
        {
            validate(board, row, column);
            if (board.BoardCellStatuses[row, column] == BoardCellStatus.Occupied || board.BoardCellStatuses[row, column] == BoardCellStatus.Hit)
            {
                board.BoardCellStatuses[row, column] = BoardCellStatus.Hit;
                board.HitCount++;
                return AttackStatus.Hit;
            }
            board.BoardCellStatuses[row, column] = BoardCellStatus.Miss;
            return AttackStatus.Miss;
        }

        private void validate(Board board, int row, int column)
        {
            string errMsg = "Attack postion cannot be outside of board.";
            if (row > board.Rows || column > board.Columns)
            {
                throw new IndexOutOfRangeException(errMsg);
            }
        }
    }
}
