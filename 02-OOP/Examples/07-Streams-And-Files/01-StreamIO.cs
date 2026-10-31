namespace OOPLearning.Examples;

/// <summary>
/// Demonstrates FileStream, StreamWriter, StreamReader, and the File helper methods.
/// </summary>
public static class StreamIO
{
    public static void Run()
    {
        string folder = Path.Combine(Path.GetTempPath(), "OOP-Learning-Streams");
        Directory.CreateDirectory(folder);

        string firstPath = Path.Combine(folder, "stream-example-1.txt");
        string secondPath = Path.Combine(folder, "stream-example-2.txt");
        string thirdPath = Path.Combine(folder, "stream-example-3.txt");
        string fourthPath = Path.Combine(folder, "stream-writer-example.txt");

        FileStreamExample1(firstPath);
        FileStreamExample2(firstPath, secondPath);
        FileStreamExample3(thirdPath);

        StreamWriterExample1(fourthPath);
        StreamWriterExample2(secondPath);

        StreamReaderExample1(fourthPath);
        StreamReaderExample2(secondPath);

        Console.WriteLine($"Demo files are stored in: {folder}");
    }

    private static void FileStreamExample1(string path)
    {
        Console.WriteLine("FileStream Example 1 - writing bytes:");

        using FileStream stream = new(path, FileMode.Create, FileAccess.ReadWrite);
        Console.WriteLine($"Length: {stream.Length} byte(s)");
        Console.WriteLine($"CanRead: {stream.CanRead}");
        Console.WriteLine($"CanSeek: {stream.CanSeek}");
        Console.WriteLine($"CanTimeout: {stream.CanTimeout}");
        Console.WriteLine($"Position before writing: {stream.Position}");

        stream.WriteByte(65); // ASCII A
        Console.WriteLine($"Position after writing: {stream.Position}");
        stream.WriteByte(13); // Carriage return

        // ASCII codes 65 to 122 include uppercase and lowercase letters and symbols.
        for (byte value = 65; value < 123; value++)
            stream.WriteByte(value);
    }

    private static void FileStreamExample2(string sourcePath, string copyPath)
    {
        Console.WriteLine("\nFileStream Example 2 - reading and copying bytes:");

        using FileStream source = new(sourcePath, FileMode.Open, FileAccess.Read);
        byte[] data = new byte[checked((int)source.Length)];
        int bytesToRead = data.Length;
        int bytesRead = 0;

        while (bytesToRead > 0)
        {
            int count = source.Read(data, bytesRead, bytesToRead);

            if (count == 0)
                break;

            bytesToRead -= count;
            bytesRead += count;
        }

        Console.WriteLine($"Bytes read: {bytesRead}");
        foreach (byte value in data.Take(bytesRead))
            Console.WriteLine(value);

        using FileStream destination = new(copyPath, FileMode.Create, FileAccess.Write);
        destination.Write(data, 0, bytesRead);
    }

    private static void FileStreamExample3(string path)
    {
        Console.WriteLine("\nFileStream Example 3 - seeking and reading:");

        using FileStream stream = new(path, FileMode.Create, FileAccess.ReadWrite);
        stream.Seek(20, SeekOrigin.Begin);
        stream.WriteByte(65);

        stream.Position = 0;
        for (long i = 0; i < stream.Length; i++)
            Console.WriteLine(stream.ReadByte());
    }

    private static void StreamWriterExample1(string path)
    {
        Console.WriteLine("\nStreamWriter Example 1:");

        using StreamWriter writer = new(path);
        writer.WriteLine("Hi");
        writer.Write("I'm Ahmed");
    }

    private static void StreamWriterExample2(string path)
    {
        Console.WriteLine("\nStreamWriter Example 2 - File helpers:");

        string[] lines = { "it's", "me" };
        File.WriteAllLines(path, lines);

        string text = "I'm Ahmed";
        File.WriteAllText(path, text); // Replaces the previous file contents.
    }

    private static void StreamReaderExample1(string path)
    {
        Console.WriteLine("\nStreamReader Example 1 - reading characters:");

        using (StreamReader reader = new(path))
        {
            while (reader.Peek() >= 0)
                Console.WriteLine((char)reader.Read());
        }

        Console.WriteLine("Reading line by line:");
        using (StreamReader reader = new(path))
        {
            string? line;
            while ((line = reader.ReadLine()) is not null)
                Console.WriteLine(line);
        }

        Console.WriteLine("File.ReadAllText:");
        Console.WriteLine(File.ReadAllText(path));
    }

    private static void StreamReaderExample2(string path)
    {
        Console.WriteLine("\nStreamReader Example 2 - File helpers:");

        Console.WriteLine(File.ReadAllText(path));

        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
            Console.WriteLine(line);
    }
}
