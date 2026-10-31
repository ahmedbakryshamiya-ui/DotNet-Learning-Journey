using System.IO.Compression;
using System.Text;

namespace OOPLearning.Examples;

/// <summary>
/// DeflateStream compresses and decompresses data streams.
/// </summary>
public static class DeflateStreamExamples
{
    public static void Run()
    {
        byte[] originalData = Encoding.UTF8.GetBytes("C# streams can compress repeated data.");

        using MemoryStream compressedOutput = new();
        using (DeflateStream compressor = new(
            compressedOutput, CompressionMode.Compress, leaveOpen: true))
        {
            compressor.Write(originalData, 0, originalData.Length);
        }

        byte[] compressedData = compressedOutput.ToArray();

        using MemoryStream compressedInput = new(compressedData);
        using DeflateStream decompressor = new(compressedInput, CompressionMode.Decompress);
        using MemoryStream decompressedOutput = new();

        decompressor.CopyTo(decompressedOutput);
        string restoredText = Encoding.UTF8.GetString(decompressedOutput.ToArray());

        Console.WriteLine($"Original bytes: {originalData.Length}");
        Console.WriteLine($"Compressed bytes: {compressedData.Length}");
        Console.WriteLine($"Restored text: {restoredText}");
    }
}
