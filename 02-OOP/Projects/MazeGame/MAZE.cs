namespace MAZE_GAME;

/// <summary>
/// Owns the maze grid, draws its cells, and moves the player through walkable spaces.
/// </summary>
public class MAZE
{
    private readonly int _width;
    private readonly int _height;
    private readonly Charachter _character;
    private readonly IMazeobject[,] _mazeObjectsArray;

    public MAZE(int width, int height)
    {
        if (width < 4)
            throw new ArgumentOutOfRangeException(nameof(width), "Maze width must be at least 4.");

        if (height < 4)
            throw new ArgumentOutOfRangeException(nameof(height), "Maze height must be at least 4.");

        _width = width;
        _height = height;
        _mazeObjectsArray = new IMazeobject[width, height];
        _character = new Charachter { X = 1, Y = 1 };
    }

    public bool HasWon { get; private set; }

    public void MovePlayer()
    {
        if (HasWon)
            return;

        ConsoleKeyInfo userInput = Console.ReadKey(intercept: true);

        switch (userInput.Key)
        {
            case ConsoleKey.UpArrow:
                UpdatePlayer(0, -1);
                break;
            case ConsoleKey.DownArrow:
                UpdatePlayer(0, 1);
                break;
            case ConsoleKey.LeftArrow:
                UpdatePlayer(-1, 0);
                break;
            case ConsoleKey.RightArrow:
                UpdatePlayer(1, 0);
                break;
            case ConsoleKey.Escape:
                HasWon = true;
                Console.WriteLine("\nGame closed.");
                break;
        }
    }

    private void UpdatePlayer(int dx, int dy)
    {
        int newX = _character.X + dx;
        int newY = _character.Y + dy;

        if (newX < 0 || newX >= _width || newY < 0 || newY >= _height)
            return;

        IMazeobject? destination = _mazeObjectsArray[newX, newY];
        if (destination is null || destination.IsSold)
            return;

        _character.X = newX;
        _character.Y = newY;

        if (newX == _width - 1 && newY == _height - 2)
        {
            HasWon = true;
            Drawmaze();
            Console.WriteLine("\nYou reached the exit. You won!");
            return;
        }

        Drawmaze();
    }

    public void Drawmaze()
    {
        Console.Clear();

        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
            {
                if (x == _character.X && y == _character.Y)
                {
                    // Keep the player's current cell marked as walkable for the next move.
                    _mazeObjectsArray[x, y] = new Empty_space();
                    Console.Write(_character.Icon);
                }
                else if (x == _width - 1 && y == _height - 2)
                {
                    _mazeObjectsArray[x, y] = new Empty_space();
                    Console.Write('E');
                }
                else if (x == 0 || y == 0 || x == _width - 1 || y == _height - 1)
                {
                    _mazeObjectsArray[x, y] = new Wall();
                    Console.Write(_mazeObjectsArray[x, y].Icon);
                }
                else if ((x % 3 == 0 && y % 3 == 0) ||
                         (x % 5 == 0 && y % 5 == 0))
                {
                    _mazeObjectsArray[x, y] = new Wall();
                    Console.Write(_mazeObjectsArray[x, y].Icon);
                }
                else
                {
                    _mazeObjectsArray[x, y] = new Empty_space();
                    Console.Write(_mazeObjectsArray[x, y].Icon);
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Use arrow keys to move. Reach E to win; press Esc to quit.");
    }
}
