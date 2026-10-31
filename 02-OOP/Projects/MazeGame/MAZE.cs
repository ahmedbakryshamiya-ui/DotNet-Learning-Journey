using System;
using System.Collections.Generic;
using System.Text;

namespace MAZE_GAME
{
    public class MAZE
    {
        private int _Width;
        private int _Height;
        private Charachter _Charachter;
        private IMazeobject[,] _MazeobjectsArray;

        public MAZE(int width, int height)
        {
            _Height = height;
            _Width = width;
            _MazeobjectsArray = new IMazeobject[width, height];
            _Charachter = new Charachter() 
            {
                X = 1,
                Y = 1,
            };

        }
        public void MovePlayer()
 
        {
            var userInpot = Console.ReadKey(); // retarn ConsoleKeyInfo
            var Key = userInpout.Key;
            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0,-1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0,1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1,0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;

            }

        }

        private void UpdatePlayer(int dx ,int dy)
        {
            int newX = _Charachter.X + dx;
            int newY = _Charachter.Y + dy;

            if (newX <_Width && newX >=0 && newY < _Height && newY >= 0 && _MazeobjectsArray[newX,newY]).IsSold == false)
            {
                _Charachter.X = newX;
                _Charachter.Y = newY;
                Drawmaze();
            }
        }

        public void Drawmaze() 
        {
            Console.Clear();
            for (int y = 0;  y< _Height; y++)
            {
                for (int x = 0; x < _Width; x++)
                {
                    // Outer walls & Exit
                    if (x == _Width -1 && y == _Height -2)
                    {
                        _MazeobjectsArray[x, y] = new Empty_space();
                        Console.Write(_MazeobjectsArray[x, y].Icon);
                    }
                 
                   else if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
                    {
                        _MazeobjectsArray[x, y] = new Wall();
                        Console.Write(_MazeobjectsArray[x, y].Icon);
                    }
                    else if (x == _Charachter.X && y == _Charachter.Y)
                    {
                        Console.Write(_Charachter.Icon);
                    }
                    else if (x %3 ==0 && y % 3 == 0)
                    {
                        _MazeobjectsArray[x, y] = new Wall();
                        Console.Write(_MazeobjectsArray[x, y].Icon);
                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {
                        _MazeobjectsArray[x, y] = new Wall();
                        Console.Write(_MazeobjectsArray[x, y].Icon);
                    }

                    else // Empty spaces
                    {
                        _MazeobjectsArray[x, y] = new Empty_space();
                        Console.Write(_MazeobjectsArray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
