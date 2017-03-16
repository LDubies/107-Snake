using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nibbles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        int ticks = 0;
        static int gwidth = 45;
        static int gheight = 35;

        Snake snake = new Snake(1, gwidth, gheight);
        Map map = new Map(1);

        //update tick counter
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            timerCountLabel.Text = ticks.ToString();

            snake.move();
            xposDispl.Text = snake.getHeadx().ToString();
            yposDispl.Text = snake.getHeady().ToString();

            clearField();
            drawWalls();
            drawSnake();
        }


        //changes snake direction on key press
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    snake.dir = 1;
                    break;
                case Keys.Right:
                    snake.dir = 2;
                    break;
                case Keys.Down:
                    snake.dir = 3;
                    break;
                case Keys.Left:
                    snake.dir = 4;
                    break;
                default:
                    break;
            }

        }

        //clears map of snake and walls
        private void clearField()
        {
            Graphics g = mapPanel.CreateGraphics();
            System.Drawing.SolidBrush groundBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            g.FillRectangle(groundBrush, 0, 0, mapPanel.Width, mapPanel.Height);

            groundBrush.Dispose();
            g.Dispose();
        }

        //draws walls onto map
        private void drawWalls()
        {
            Graphics g = mapPanel.CreateGraphics();
            System.Drawing.SolidBrush wallBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

            int xsector = mapPanel.Width / gwidth;
            int ysector = mapPanel.Height / gheight;
            int[,] m = map.getWalls();
            int xdim = m.GetLength(0);
            int ydim = m.GetLength(1);

            for (int i = 0; i < xdim; i++)
            {
                for (int j = 0; j < ydim; j++)
                {
                    if (m[i, j] > 0)
                    {
                        g.FillRectangle(wallBrush, i * xsector, j * ysector, xsector, ysector);
                    }
                }
            }

        }

        //draws snake onto the panel
        private void drawSnake()
        {
            Graphics g = mapPanel.CreateGraphics();
            System.Drawing.SolidBrush snakeBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            
            //paint snake
            int xsector =mapPanel.Width / gwidth;
            int ysector = mapPanel.Height / gheight;
            int[,] m = snake.getMatrix();
            int xdim = m.GetLength(0);
            int ydim = m.GetLength(1);

            for (int i = 0; i < xdim; i++)
            {
                for (int j = 0; j < ydim; j++)
                {
                    if (m[i, j] > 0)
                    {
                        g.FillRectangle(snakeBrush, i * xsector, j * ysector, xsector, ysector);
                    }
                }
            }
            



            snakeBrush.Dispose();
            g.Dispose();

        }

    }
}
