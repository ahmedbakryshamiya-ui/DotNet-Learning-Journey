namespace MAZE_GAME;

/// <summary>
/// Represents a walkable cell in the maze.
/// </summary>
internal sealed class Empty_space : IMazeobject
{
    public char Icon => ' ';
    public bool IsSold => false;
}
