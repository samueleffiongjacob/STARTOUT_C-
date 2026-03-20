//using System.IO;// for file handling

namespace AdvanceConcept.FileIO
{

    /** File I/O (Input/Output)
        File I/O refers to the operations performed on files, such as reading from and writing to files. In C#, you can use the System.IO namespace to work with files.
        Here are some common file I/O operations:
        1. Writing to a file:
           - File.WriteAllText(): Writes a string to a file, creating the file if it does not exist or overwriting it if it does.
           - File.AppendAllText(): Appends a string to the end of a file, creating the file if it does not exist.
        2. Reading from a file:
           - File.ReadAllText(): Reads the entire contents of a file into a string.
           - File.ReadAllLines(): Reads all lines of a file into an array of strings.
        3. Checking if a file exists:
           - File.Exists(): Checks if a specified file exists.
        4. Deleting a file:
           - File.Delete(): Deletes a specified file.
        5. Getting file information:
           - FileInfo class: Provides properties and methods for working with files, such as getting the size, creation time, and last modified time of a file.
        6. Using StreamReader and StreamWriter for more advanced file handling, such as reading and writing large files or working with binary data.
        7. creating files and directories using Directory class and FileStream class for more control over file operations.
           - Create(): Creates a file and returns a FileStream object that can be used to write to the file.
           - copy(): Copies an existing file to a new file.
        File.SomeFileMethod();  // use the file class with methods
     */
    class FileStart
    {
        /*
         * Write To a File and Read It
           In the following example, we use the WriteAllText() method to create a file named "filename.txt" and write some content to it. Then we use the ReadAllText() method to read the contents of the file:
        */

        public static void RunFileStartExample()
        { 
            string filePath = "filename.txt";
            string contentToWrite = "Hello, this is a sample file.\nWelcome to C# File I/O!\n Am Samuel Effiong";
            
            // Write to the file
            File.WriteAllText(filePath, contentToWrite);
            Console.WriteLine($"✅ Written to {filePath}");
            
            // Read from the file
            string contentRead = File.ReadAllText(filePath);
            Console.WriteLine("📖 Content read from file:");
            Console.WriteLine(contentRead);

            // Clean up - delete the file after use
            Console.WriteLine("deleting the file...");
            File.Delete(filePath);
            Console.WriteLine($"✅ Deleted {filePath}");
            Console.WriteLine("File I/O operations completed. by deleting file");
        }
    }
}
