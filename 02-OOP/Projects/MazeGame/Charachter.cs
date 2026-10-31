namespace MAZE_GAME;

/// <summary>
/// Represents the player and the player's current grid coordinates.
/// </summary>
internal sealed class Charachter : IMazeobject
{
    public char Icon => '@';
    public bool IsSold => true;
    public int X { get; set; }
    public int Y { get; set; }
}
