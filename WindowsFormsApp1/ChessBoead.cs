using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    //棋盘
    internal class ChessBoead
    {

        //棋盘
        public static void DramCB(Graphics g)
        {
            int GapWidth = MainSize.CBoardGap;
            int GapNum = MainSize.CBoardWidth / GapWidth - 1;
            g.Clear(Color.Bisque);
            Pen pen = new Pen(Color.Black);
            for (int i = 0; i < GapNum + 1; i++)
            {
                g.DrawLine(pen, new Point(20, i * GapWidth + 20), new Point(GapWidth * GapNum + 20, i * GapWidth + 20));
                g.DrawLine(pen, new Point(i * GapWidth + 20, 20), new Point(i * GapWidth + 20, GapWidth * GapNum + 20));

            }
        }
    }
}
