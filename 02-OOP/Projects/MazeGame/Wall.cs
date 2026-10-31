namespace MAZE_GAME;

/// <summary>
/// Represents an impassable wall cell.
/// </summary>
internal sealed class Wall : IMazeobject
{
    public char Icon => '#';
    public bool IsSold => true;
}
