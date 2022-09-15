using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private bool start;  //检测是否开始
        private bool ChessCheck = true;  //黑白
        private const int size = 15;  //大小



        private int[,] CheckBoard = new int[size, size];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeGame();    //初始化
            this.Width = MainSize.FormWidth;    //宽，高
            this.Height = MainSize.FormHeight;
            this.Location = new Point(400, 75);  //窗口位置

        }
        private void initializeGame()
        {
            //System.Diagnostics.Debug.WriteLine("initializeGame");//检测
            for (int i = 0; i < size; i++)   //棋盘
            {
                for (int j = 0; j < size; j++)
                {
                    CheckBoard[i, j] = 0;
                }

            }
            start = false;
            label1.Text = "まだはじめていません";
            button1.Visible = true;    //显示按钮
            button2.Visible = false;

            button3.Visible = true;

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            ChessBoead.DramCB(g);
            Chess.ReDrawC(panel2, CheckBoard);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Size = new Size(MainSize.FormWidth - MainSize.CBoardWidth, MainSize.FormHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = true;
            label1.Text = "黑";
            ChessCheck = true;
            button1.Visible = false;
            button2.Visible = true;
            panel2.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yes", "No", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                initializeGame();
                button1_Click(sender, e);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (start)
            {
                int Judgment = 0;
                int PlacementX = e.X / MainSize.CBoardGap;
                int PlacementY = e.Y / MainSize.CBoardGap;
                try
                {
                    if (CheckBoard[PlacementX, PlacementY] != 0)
                    {
                        return;
                    }
                    if (ChessCheck)
                    {
                        CheckBoard[PlacementX, PlacementY] = 1;
                        Judgment = 1;
                        label1.Text = "白";

                    }
                    else
                    {
                        CheckBoard[PlacementX, PlacementY] = 2;
                        Judgment = 2;
                        label1.Text = "黑";
                    }
                    Chess.DrawC(panel2, ChessCheck, PlacementX, PlacementY);
                    if (WinJudgment.ChessJudgment(CheckBoard, Judgment))
                    {
                        if (Judgment == 1)
                        {
                            MessageBox.Show("黑Win", "Win");
                        }
                        else
                        {
                            MessageBox.Show("白Win", "Win");
                        }
                        initializeGame();
                    }
                    ChessCheck = !ChessCheck;
                }
                catch (Exception) { }


            }
            else
            {
                MessageBox.Show("まだはじめていません", " ");
            }
        }
    }
}
