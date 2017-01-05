using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nibbles
{
    class Snake
    {
        //properties
        //****************************
        int height, width;
        int speed;
        int length = 5;

        int headx = 5;
        int heady = 5;

        //1,...,4 for up,...,left clockwise
         public int dir = 1;
        bool crashed = false;



        //constructor
        //****************************
        public Snake(int _speed, int _height, int _width)
        {
            this.speed = _speed;
            this.height = _height;
            this.width = _width;

            int[,] pos = new int[height, width];
        }

        //methods
        //****************************

            //getter & setter 4 head pos
        public int getHeadx()
        {
            return headx;
        }

        public int getHeady()
        {
            return heady;
        }

        public void setHeadx(int x)
        {
           headx = x;
        }

        public void setHeady(int y)
        {
           heady = y;
        }


        //moving the snake 1 step
        public void move()
        {

            int oldx = headx;
            int oldy = heady;

            switch (dir)
            {
                case 1:
                    heady = heady - 1;
                    break;
                case 2:
                    headx = headx + 1;
                    break;
                case 3:
                    heady = heady + 1;
                    break;
                case 4:
                    headx = headx - 1;
                    break;
                default:
                    break;
            }

            if (checkBounds() == false) {
                headx = oldx;
                heady = oldy;
                crashed = true;
            }

         
        }


        //checks if snakes head is in bounds
        public bool checkBounds()
        {
            bool inBounds = false;

            if (headx >= 0 && headx < width && heady >= 0 && heady < height) {
                inBounds = true;
            }

            return inBounds;
        }
    }
}
