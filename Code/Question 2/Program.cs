namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = GetPath();
            CheckFile(path);
            Console.ReadLine();
        }

        static string GetPath()
        {
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine("Current directory: {0}",
                currentDir);
            Console.WriteLine
                ("What is the path to the directory?");
            return Console.ReadLine();
        }

        static void CheckFile(string path)
        {
            bool dirExists = Directory.Exists(path);

            if (dirExists)
            {
                DateTime createTime =
                    Directory.GetCreationTime(path);
                DateTime accessTime =
                    Directory.GetLastAccessTime(path);
                DateTime writeTime =
                    Directory.GetLastWriteTime(path);
                Console.WriteLine
                    ("Create time: {0}", createTime);
                Console.WriteLine
                    ("Access time: {0}", accessTime);
                Console.WriteLine
                    ("Write time: {0}", writeTime);

                string[] subDirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                Console.WriteLine("There are {0} sub directories"
                    + " and {1} files", subDirs.Length, files.Length);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine
                    ("Error: No directory exists at path {0}",
                    path);
            }
        }
    }
}