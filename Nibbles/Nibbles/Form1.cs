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

        Snake snake = new Snake(1, 10, 10);

        //update tick counter
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            timerCountLabel.Text = ticks.ToString();

            snake.move();
            xposDispl.Text = snake.getHeadx().ToString();
            yposDispl.Text = snake.getHeady().ToString();
        }



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
    }
}
