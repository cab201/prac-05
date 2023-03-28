namespace Code
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
                ("What is the path to the file?");
            return Console.ReadLine();
        }

        static void CheckFile(string path)
        {
            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                DateTime createTime = 
                    File.GetCreationTime(path);
                DateTime accessTime = 
                    File.GetLastAccessTime(path);
                DateTime writeTime = 
                    File.GetLastWriteTime(path);
                Console.WriteLine
                    ("Create time: {0}", createTime);
                Console.WriteLine
                    ("Access time: {0}", accessTime);
                Console.WriteLine
                    ("Write time: {0}", writeTime);
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine
                    ("Error: No file exists at path {0}",
                    path);
            }
        }
    }
}