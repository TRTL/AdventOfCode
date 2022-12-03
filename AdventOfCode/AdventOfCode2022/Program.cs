using AdventOfCode2022.Day_1;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Advent of code 2022!");

            Day1Method();

        }

        static void Day1Method()
        {
            Day1 day1_result = new Day1();
            Console.WriteLine("Day1 Result1: " + day1_result.ReadFileAndGetMostCalories());
            Console.WriteLine("Day1 Result2: " + day1_result.ReadFileAndGetMostCaloriesForThreeElfs());
        }












    }
}