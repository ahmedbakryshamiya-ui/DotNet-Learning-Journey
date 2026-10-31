using System.IO.Compression;
using System.Text;

namespace OOPLearning.Examples;

/// <summary>
/// DeflateStream provides compression and decompression for another stream using the Deflate algorithm. Disposing the compression stream completes the compressed output; leaveOpen controls whether the underlying stream remains open when the DeflateStream is disposed.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.deflatestream
/// </remarks>
public static class DeflateStreamExamples
{
    public static void Run()
    {
        // Walkthrough: DeflateStream provides compression and decompression for another stream using the Deflate algorithm. Disposing the compression stream completes the compressed output; leaveOpen controls whether the underlying stream remains open when the DeflateStream is disposed.
        byte[] originalData = Encoding.UTF8.GetBytes("C# streams can compress repeated data.");

        using MemoryStream compressedOutput = new();
        // leaveOpen keeps compressedOutput available after the compressor is disposed.
        using (DeflateStream compressor = new(
            compressedOutput, CompressionMode.Compress, leaveOpen: true))
        {
            compressor.Write(originalData, 0, originalData.Length);
        }

        // Dispose finishes the compressed stream before its bytes are copied from MemoryStream.
        byte[] compressedData = compressedOutput.ToArray();

        using MemoryStream compressedInput = new(compressedData);
        using DeflateStream decompressor = new(compressedInput, CompressionMode.Decompress);
        using MemoryStream decompressedOutput = new();

        // CopyTo reads decompressed bytes until the DeflateStream reaches the end.
        decompressor.CopyTo(decompressedOutput);
        string restoredText = Encoding.UTF8.GetString(decompressedOutput.ToArray());

        Console.WriteLine($"Original bytes: {originalData.Length}");
        Console.WriteLine($"Compressed bytes: {compressedData.Length}");
        Console.WriteLine($"Restored text: {restoredText}");
    }
}
