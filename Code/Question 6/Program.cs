using System.ComponentModel.DataAnnotations;

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile("EmployeeDetails.txt");
        }

        static void ReadFile(string path)
        {
            if (File.Exists(path))
            {
                List<double> salaries = new List<double>();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        double salary = double.Parse(line.Split(",")[2]);
                        salaries.Add(salary);
                    } while (!reader.EndOfStream);
                }

                double average = salaries.Sum() / salaries.Count;
                double max = salaries.Max();
                double min = salaries.Min();
                Console.WriteLine("The min is {0}, max {1}, average {2}",
                    min, max, average);
            }
        }
    }
}