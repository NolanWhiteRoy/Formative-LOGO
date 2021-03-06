﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Formative_LOGO
{
    public partial class PG : Form
    {
        public PG ()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
        }

        private void PlayGame_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font timesFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font comicFont = new Font("ComicSans", 10, FontStyle.Bold);

            PG.Visible = false;
            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);
            g.DrawLine(drawPen, 25, 125, 200, 125);
            g.DrawLine(drawPen, 300, 20, 300, 225);
            g.DrawLine(drawPen, 200, 120, 200, 225);
            g.FillPie(yellowBrush, 45, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 45, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 55, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 55, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 65, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 65, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 75, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 75, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 85, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 85, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 95, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 95, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 105, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 105, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 115, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 115, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 125, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 125, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 135, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 135, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 145, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 145, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 155, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 155, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 165, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 165, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 175, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 175, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 185, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 185, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 195, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 195, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 205, 45, 60, 60, 25, 315);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 205, 45, 60, 60, 25, 315);
            g.FillPie(yellowBrush, 215, 45, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 45, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 215, 45, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 45, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 55, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 55, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 215, 65, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 65, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 75, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 75, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 215, 85, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 85, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 95, 60, 60, 113, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 95, 60, 60, 113, 360);
            g.FillPie(yellowBrush, 215, 105, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 105, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 115, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 115, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 215, 125, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 125, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 135, 60, 60, 113, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 135, 60, 60, 113, 360);
            g.FillPie(yellowBrush, 215, 145, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 145, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 155, 60, 60, 0, 360);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 155, 60, 60, 0, 360);
            g.FillPie(yellowBrush, 215, 165, 60, 60, 113, 314);
            Thread.Sleep(250);

            g.FillPie(blackBrush, 215, 165, 60, 60, 113, 314);
            g.FillPie(yellowBrush, 215, 175, 60, 60, 113, 360);
            Thread.Sleep(250);

            g.DrawString("GAME OVER", timesFont, yellowBrush, 50, 40);
            Thread.Sleep(3000);
            Refresh();

            PG.Visible = true;
        }
    }
}
