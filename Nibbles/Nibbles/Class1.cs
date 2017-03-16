using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nibbles
{
    class Map
    {
        //properties
        int width, height;
        private int level; //starting at 1
        int[,] walls;

        //constructor
        public Map(int _level)
        {
            this.level = _level;
            this.width = 45;
            this.height = 35;
            changeWalls();
        }

        //methods
        public int getLevel()
        {
            return level;
        }

        public void setLevel(int i)
        {
            level = i;
            changeWalls();
        }

        public void incLevel()
        {
            level++;
            changeWalls();
        }

        //set walls according to level
        private void changeWalls()
        {
            if (level == 1)
            //setup lvl 1 (basically just the border)
            {
                walls = new int[45, 35];
                for (int i = 0; i < 45; i++)
                {
                    if (walls[i,0] == 0)
                    {
                        walls[i, 0] = 1;
                    }
                }

                for (int i = 0; i < 45; i++)
                {
                    if (walls[i, 34] == 0)
                    {
                        walls[i, 34] = 1;
                    }
                }

                for (int i = 0; i < 35; i++)
                {
                    if (walls[44, i] == 0)
                    {
                        walls[44, i] = 1;
                    }
                }

                for (int i = 0; i < 35; i++)
                {
                    if (walls[0, i] == 0)
                    {
                        walls[0, i] = 1;
                    }
                }
            } else //starting with simple lvl 2 for test purposes
            {
                walls = new int[45, 35];
                for (int i = 0; i < 45; i++)
                {
                    if (walls[i, 0] == 0)
                    {
                        walls[i, 0] = 1;
                    }
                }

                for (int i = 0; i < 45; i++)
                {
                    if (walls[i, 34] == 0)
                    {
                        walls[i, 34] = 1;
                    }
                }

                for (int i = 0; i < 35; i++)
                {
                    if (walls[44, i] == 0)
                    {
                        walls[44, i] = 1;
                    }
                }

                for (int i = 0; i < 35; i++)
                {
                    if (walls[0, i] == 0)
                    {
                        walls[0, i] = 1;
                    }
                }

                for (int i = 0; i < 35; i++)
                {
                    if (walls[22, i] == 0 && i != 18)
                    {
                        walls[22, i] = 1;
                    }
                }
            }
        }
    }
}
