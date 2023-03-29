namespace Question_3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = GetPath();
            ReadFile(pathToFile);

            // Print to a file
            Console.WriteLine("Printing to a file...");
            pathToFile = GetPath();
            WriteFile(pathToFile);
        }

        static string GetPath()
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("What is the path to the file?");
            return Console.ReadLine();
        }

        static void ReadFile(string path)
        {
            if (File.Exists(path))
            {
                ReadFileContent(path);
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No file exists at {0}",
                    path);
            }
        }

        static void ReadFileContent(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
                // Repeat until there's nothing to read
                while (line != null)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }

        // Check if a file exist. If it does, write something to it.
        static void WriteFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter writer = 
                    new StreamWriter(path, append: true))
                {
                    writer.WriteLine(@"In fairy-tales, witches always wear silly black hats and black coats, 
and they ride on broomsticks. 
But this is not a fairy-tale. 
This is about REAL WITCHES.");
                }
            } else
            {
                Console.WriteLine("Error: No file exists at path {0}", path);
            }
        }
    }
}