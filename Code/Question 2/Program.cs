namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = GetDirectoryName();
            CheckDirectory(path);
        }

        // Get the path to the directory from the user
        static string GetDirectoryName()
        {
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine("Current directory {0}", currentDir);
            Console.WriteLine("Enter path to file:");
            return Console.ReadLine();
        }

        // Check the directory, its creation, written and accessed
        // time.
        // Also show sub directories and files
        static void CheckDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine("Creation time:");
                Console.WriteLine(Directory.GetCreationTime(path));
                Console.WriteLine("Written time:");
                Console.WriteLine(Directory.GetLastWriteTime(path));
                Console.WriteLine("Accessed time:");
                Console.WriteLine(Directory.GetLastAccessTime(path));
                // Get the files in the directory
                string[] files = Directory.GetFiles(path);
                // Get the sub-folders in the directory
                string[] subDirs = Directory.GetDirectories(path);
                Console.WriteLine("This directory has {0} files and {1} sub-folders.",
                    files.Length, subDirs.Length);
            } else
            {
                Console.WriteLine("Directory at path {0} does not exist", path);
            }
        }
    }
}