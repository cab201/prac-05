namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get path from user, then check if file exists
            string path = GetFileName();
            CheckFile(path);
            Console.ReadLine();
        }

        // Get the file name from the user
        static string GetFileName()
        {
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine("Current directory {0}", currentDir);
            Console.WriteLine("What is the path to the file?");
            return Console.ReadLine();
        }

        // Check if the file at a given path exists.
        // If it does, print creation time, last written and accessed
        // time.
        // If if does not, print an error message
        static void CheckFile(string path)
        {
            bool fileExists = File.Exists(path);
            if (fileExists)
            {
                Console.WriteLine("The creation time was");
                Console.WriteLine(File.GetCreationTime(path));
                Console.WriteLine("The last written time was");
                Console.WriteLine(File.GetLastWriteTime(path));
                Console.WriteLine("The last accessed time was");
                Console.WriteLine(File.GetLastAccessTime(path));
            } else
            {
                Console.WriteLine("The file does not exist");
            }
        }
    }
}