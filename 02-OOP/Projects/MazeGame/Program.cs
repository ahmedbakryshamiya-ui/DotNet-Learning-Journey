namespace MAZE_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello to MAZE game"
            //    + "\nUse keyboard arrows to move the player");
            MAZE maze = new MAZE(40, 20);
            while (true) 
            {
                maze.Drawmaze();
                maze.MovePlayer();
            }

        }
    }
}
