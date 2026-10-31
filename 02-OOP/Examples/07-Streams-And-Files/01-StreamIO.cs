namespace OOPLearning.Examples;

/// <summary>
/// Streams read and write data; readers and writers make text operations easier.
/// </summary>
public static class StreamIO
{
    public static void Run()
    {
        string path = Path.Combine(Path.GetTempPath(), "oop-stream-demo.txt");

        // FileStream works with bytes.
        using (FileStream stream = new(path, FileMode.Create, FileAccess.Write))
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello from FileStream.");
            stream.Write(data, 0, data.Length);
        }

        // StreamWriter writes text; StreamReader reads it.
        using (StreamWriter writer = new(path, append: true))
        {
            writer.WriteLine();
            writer.WriteLine("Written by StreamWriter.");
        }

        using (StreamReader reader = new(path))
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        Console.WriteLine($"File saved to: {path}");
        Console.WriteLine($"ReadAllText: {File.ReadAllText(path)}");
    }
}
