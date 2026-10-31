using System;
using System.Collections.Generic;
using System.Text;

namespace MAZE_GAME
{
    internal class Wall : IMazeobject
    {
        public char Icon { get => '#'; }
        public bool IsSold { get => true; }
    }
}
