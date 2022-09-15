using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WinJudgment
    {
        public static bool ChessJudgment(int[,] CheckBoard, int Judgment)
        {
            bool Win = false;
            for (int i = 0; i < CheckBoard.GetLength(1); i++)
            {
                for (int j = 0; j < CheckBoard.GetLength(0); j++)
                {
                    if (CheckBoard[j, i] == Judgment)
                    {
                        if (j < 11)
                        {
                            if (CheckBoard[j + 1, i] == Judgment && CheckBoard[j + 2, i] == Judgment && CheckBoard[j + 3, i] == Judgment && CheckBoard[j + 4, i] == Judgment)
                            {
                                return Win = true;
                            }
                        }
                        if (i < 11)
                        {
                            if (CheckBoard[j, i + 1] == Judgment && CheckBoard[j, i + 2] == Judgment && CheckBoard[j, i + 3] == Judgment && CheckBoard[j, i + 4] == Judgment)
                            {
                                return Win = true;
                            }
                        }
                        if (j < 11 && i < 11)
                        {
                            if (CheckBoard[j + 1, i + 1] == Judgment && CheckBoard[j + 2, i + 2] == Judgment && CheckBoard[j + 3, i + 3] == Judgment && CheckBoard[j + 4, i + 4] == Judgment)
                            {
                                return Win = true;
                            }
                        }
                        if (j > 3 && i < 11)
                        {
                            if (CheckBoard[j - 1, i + 1] == Judgment && CheckBoard[j - 2, i + 2] == Judgment && CheckBoard[j - 3, i + 3] == Judgment && CheckBoard[j - 4, i + 4] == Judgment)
                            {
                                return Win = true;
                            }
                        }
                    }
                }
            }
            return Win;
        }
    }
}

