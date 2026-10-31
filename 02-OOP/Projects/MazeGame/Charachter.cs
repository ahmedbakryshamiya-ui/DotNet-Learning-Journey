using System;
using System.Collections.Generic;
using System.Text;

namespace MAZE_GAME
{
    internal class Charachter : IMazeobject
    {
        public char Icon { get => '@'; }
        public bool IsSold { get => true; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
