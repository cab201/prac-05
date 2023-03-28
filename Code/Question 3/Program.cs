namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = GetFileName();
            CheckFile(path);
        }

        // Get the file name from the user
        static string GetFileName()
        {
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine("Current directory {0}", currentDir);
            Console.WriteLine("What is the path to the file?");
            return Console.ReadLine();
        }

        static void CheckFile(string path)
        {
            bool fileExists = File.Exists(path);
            if (fileExists)
            {
                // Using StreamReader to read the whole content of a file
                DisplayFileContent(path);
                // Using StreamWriter to write to a file
                using (StreamWriter writer = 
                    new StreamWriter(path, append: true))
                {
                    // This will add a new line
                    writer.WriteLine();
                    string input;
                    // Write until the user inputs QUIT
                    do
                    {
                        Console.WriteLine
                            ("What do you want to add to the file");
                        input = Console.ReadLine();
                        writer.WriteLine(input);
                    } while (input != "QUIT");
                }
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }

        static void DisplayFileContent(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = null;
                // Read through the whole file
                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                } while (!reader.EndOfStream);
            }
        }
    }
}