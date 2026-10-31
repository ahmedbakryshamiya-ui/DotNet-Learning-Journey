namespace MAZE_GAME;

/// <summary>
/// Common contract implemented by objects that can occupy a maze cell.
/// </summary>
public interface IMazeobject
{
    char Icon { get; }
    bool IsSold { get; }
}
