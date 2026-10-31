namespace MAZE_GAME;

internal static class Program
{
    private static void Main()
    {
        MAZE maze = new(40, 20);

        maze.Drawmaze();
        while (!maze.HasWon)
            maze.MovePlayer();
    }
}
