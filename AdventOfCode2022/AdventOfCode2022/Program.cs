using AdventOfCode2022.Day_1;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Advent of code 2022!");

            Day1 day1_result1 = new Day1();

            Console.WriteLine(day1_result1.ReadFileAndGetMostCalories());
            Console.WriteLine(day1_result1.ReadFileAndGetMostCaloriesForThreeElfs());
            
        }
    }
}