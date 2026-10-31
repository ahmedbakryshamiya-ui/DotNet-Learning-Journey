# Maze Game

A console maze demo using an interface, a two-dimensional object grid, and keyboard movement.

## Run

Open [MazeGame.slnx](MazeGame.slnx) in Visual Studio, or run:

```bash
dotnet run --project MazeGame.csproj
```

Use the arrow keys to move the player (`@`) to the exit (`E`). Walls are shown as `#`. Press Esc to quit.

## Class diagram

![Maze Game class diagram](MazeGame.svg)

- [Open the editable Draw.io diagram](MazeGame.drawio)

## Main types

| Type | Responsibility |
|---|---|
| `IMazeobject` | Common contract: `Icon` and `IsSold`. |
| `MAZE` | Owns the grid and player, draws the maze, reads movement keys, validates moves, and detects the exit. |
| `Charachter` | Player object; icon `@`, current X/Y coordinates, and `IsSold = true`. |
| `Wall` | Obstacle object; icon `#` and `IsSold = true`. |
| `Empty_space` | Walkable cell; a blank icon and `IsSold = false`. |
| `Program` | Creates a 40×20 maze and runs until the player wins or presses Esc. |

## Movement flow

1. `Program` calls `Drawmaze()` to initialize and display the grid.
2. `MovePlayer()` reads one key and maps an arrow key to a coordinate change.
3. `UpdatePlayer(dx, dy)` calculates the next X/Y position.
4. The move is accepted only when it is inside the grid and the destination cell is walkable.
5. The current player cell is kept marked as walkable, so the player can move away and later return.
6. Reaching `E` sets `HasWon` and ends the game loop.

## Remaining design limitation

The obstacle pattern is deterministic: a wall is placed when both coordinates are divisible by 3 or both are divisible by 5. It is not a maze-generation algorithm and does not guarantee multiple routes, solvability for arbitrary dimensions, or increasing difficulty.
