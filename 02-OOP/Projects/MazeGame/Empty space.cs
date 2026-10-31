using System;
using System.Collections.Generic;
using System.Text;

namespace MAZE_GAME
{
    internal class Empty_space : IMazeobject
    {
        public char Icon { get =>' '; }
        public bool IsSold { get =>false ; }
    }
}
