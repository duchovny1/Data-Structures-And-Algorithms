using System;

namespace _8_Queens_Puzzle
{
    class Program
    {
        private static char[,] chessboard;

        static void Main(string[] args)
        {
            MarkTheChessBoard();
            PlaceTheQueens(0);
        }

        private static void MarkTheChessBoard()
        {
            chessboard = new char[8, 8];

            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                for (int j = 0; j < chessboard.GetLength(1); j++)
                {

                    chessboard[i, j] = '0';
                }
            }
            ;
        }

        private static void PlaceTheQueens(int row)
        {
            if (row == 8)
            {
                Print();
            }
            else
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (IsValidPosition(row, col))
                    {
                        MarkPositions(row, col);
                        PlaceTheQueens(row + 1);
                        UnmarkPositions(row, col);

                    }
                }
            }
        }

        private static void UnmarkPositions(int row, int col)
        {
            chessboard[row, col] = '0';
            //unmark the rows
            for (int i = 0; i <= 7; i++)
            {
                if (CanUnmark(row, i))
                {
                    chessboard[row, i] = '0';
                }
                if (CanUnmark(i, col))
                {
                    chessboard[i, col] = '0';
                }

            }

            int currentRow = row;
            int currentCol = col;

            for (int i = currentRow; i < 7; i++)
            {
                if (currentCol > 7)
                {
                    break;
                }
                if (CanUnmark(i, currentCol))
                {
                    chessboard[i, currentCol] = '0';
                }
                currentCol++;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i > 0; i--)
            {
                if (currentCol < 0)
                {
                    break;
                }
                if (CanUnmark(i, currentCol))
                {
                    chessboard[i, currentCol] = '0';
                }

                currentCol--;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i > 0; i--)
            {
                if (currentCol > 7)
                {
                    break;
                }
                if (CanUnmark(i, currentCol))
                {
                    chessboard[i, currentCol] = '0';
                }

                currentCol++;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i <= 7; i++)
            {
                if (currentCol < 0)
                {
                    break;
                }
                if (CanUnmark(i, currentCol))
                {
                    chessboard[i, currentCol] = '0';
                }

                currentCol--;
            }

        }

        private static bool CanUnmark(int row, int col)
        {
            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                if (chessboard[row, i] == '*')
                {
                    return false;
                }
                if (chessboard[i, col] == '*')
                {
                    return false;
                }
            }

            int currentRow = row;
            int currentCol = col;

            for (int i = currentRow; i <= 7; i++)
            {
                if (currentCol > 7)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    return false;
                }
                currentCol++;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i >= 0; i--)
            {
                if (currentCol < 0)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    return false;
                }

                currentCol--;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i >= 0; i--)
            {
                if (currentCol > 7)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    return false;

                }

                currentCol++;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i <= 7; i++)
            {
                if (currentCol < 0)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    return false;
                }

                currentCol--;
            }

            return true;
        }

        private static void MarkPositions(int row, int col)
        {

            //mark the queen
            chessboard[row, col] = '*';



            //mark the row
            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                if (chessboard[row, i] == '*')
                {
                    continue;
                }

                chessboard[row, i] = '-';
            }
            //mark the col
            for (int j = 0; j < chessboard.GetLength(1); j++)
            {
                if (chessboard[j, col] == '*')
                {
                    continue;
                }

                chessboard[j, col] = '-';
            }

            int currentRow = row;
            int currentCol = col;

            //mark diaganols

            //first one
            for (int i = row; i < chessboard.GetLength(0); i++)
            {
                if (currentCol > 7)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    currentCol++;
                    continue;
                }
                chessboard[i, currentCol] = '-';
                currentCol++;

            }

            currentRow = row;
            currentCol = col;

            for (int i = row; i >= 0; i--)
            {
                if (currentCol < 0)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    currentCol--;
                    continue;
                }

                chessboard[i, currentCol] = '-';
                currentCol--;
            }

            //second one

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i >= 0; i--)
            {
                if (currentCol > 7)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    currentCol++;
                    continue;
                }
                chessboard[i, currentCol] = '-';
                currentCol++;
            }

            currentRow = row;
            currentCol = col;

            for (int i = currentRow; i <= 7; i++)
            {
                if (currentCol < 0)
                {
                    break;
                }
                if (chessboard[i, currentCol] == '*')
                {
                    currentCol--;
                    continue;
                }

                chessboard[i, currentCol] = '-';
                currentCol--;

            }
        }

        private static bool IsValidPosition(int row, int col)
        {
            if (CanUnmark(row, col))
            {
                return true;
            }

            return false;
        }

        private static void Print()
        {
            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                for (int j = 0; j < chessboard.GetLength(1); j++)
                {
                    Console.Write(chessboard[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
