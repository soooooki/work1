using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    internal class Chess
    {
        public static void DrawC(Panel p, bool ChessCheck, int PlacementX, int PlacementY)
        {
            Graphics g = p.CreateGraphics();
            int AccurateX = PlacementX * MainSize.CBoardGap + 20 - 17;
            int AccurateY = PlacementY * MainSize.CBoardGap + 20 - 17;

            if (ChessCheck)  //判断黑白
            {
                g.FillEllipse(new LinearGradientBrush(new Point(20, 0), new Point(20, 40), Color.FromArgb(122, 122, 122), Color.FromArgb(0, 0, 0)), new Rectangle(new Point(AccurateX, AccurateY), new Size(MainSize.ChessDlameter, MainSize.ChessDlameter)));
            }
            else
            {
                g.FillEllipse(new LinearGradientBrush(new Point(20, 0), new Point(20, 40), Color.FromArgb(255, 255, 255), Color.FromArgb(204, 204, 204)), new Rectangle(new Point(AccurateX, AccurateY), new Size(MainSize.ChessDlameter, MainSize.ChessDlameter)));
            }

        }

        public static void ReDrawC(Panel p, int[,] CheckBoard)   //重新加载
        {
            Graphics g = p.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            for (int i = 0; i < CheckBoard.GetLength(1); i++)
            {
                for (int j = 0; j < CheckBoard.GetLength(0); j++)
                {
                    int Judgment = CheckBoard[i, j];
                    if (Judgment != 0)
                    {
                        int AccurateX = j * MainSize.CBoardGap + 20 - 17;
                        int AccurateY = i * MainSize.CBoardGap + 20 - 17;
                        if (Judgment == 1)
                        {
                            g.FillEllipse(new LinearGradientBrush(new Point(20, 0), new Point(20, 40), Color.FromArgb(122, 122, 122), Color.FromArgb(0, 0, 0)), new Rectangle(new Point(AccurateX, AccurateY), new Size(MainSize.ChessDlameter, MainSize.ChessDlameter)));
                        }
                        else
                        {
                            g.FillEllipse(new LinearGradientBrush(new Point(20, 0), new Point(20, 40), Color.FromArgb(255, 255, 255), Color.FromArgb(204, 204, 204)), new Rectangle(new Point(AccurateX, AccurateY), new Size(MainSize.ChessDlameter, MainSize.ChessDlameter)));
                        }


                    }
                }
            }
        }
    }
}
    

