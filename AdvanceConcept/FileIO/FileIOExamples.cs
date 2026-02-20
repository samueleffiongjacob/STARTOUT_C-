namespace AdvanceConcept.FileIO
{
    public static class FileIOExamples
    {
        public static void RunExamples()
        {
            Console.WriteLine("📁 File I/O Operations...\n");

            string filePath = "sample.txt";

            // Write to file
            Console.WriteLine("1. Writing to file...");
            File.WriteAllText(filePath, "Hello from C#!\n");
            File.AppendAllText(filePath, "Learning advanced concepts.\n");
            File.AppendAllText(filePath, "File I/O is powerful!\n");
            Console.WriteLine($"✅ Written to {filePath}");

            Console.WriteLine();

            // Read from file
            Console.WriteLine("2. Reading from file:");
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // Read lines
            Console.WriteLine("3. Reading line by line:");
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"  Line {i + 1}: {lines[i]}");
            }

            Console.WriteLine();

            // Check if file exists
            Console.WriteLine("4. File operations:");
            bool exists = File.Exists(filePath);
            Console.WriteLine($"  File exists? {exists}");

            if (exists)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"  File size: {fileInfo.Length} bytes");
                Console.WriteLine($"  Created: {fileInfo.CreationTime}");
                Console.WriteLine($"  Last modified: {fileInfo.LastWriteTime}");
            }

            Console.WriteLine();

            // Delete file
            Console.WriteLine("5. Cleaning up...");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"✅ Deleted {filePath}");
            }
        }
    }
}