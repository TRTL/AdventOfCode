using AdventOfCode2022.Day_02;
using AdventOfCode2022.Day_1;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Advent of code 2022!");

            //Day1Method();

            Day2Method();

        }

        static void Day1Method()
        {
            Day1 day1_result = new Day1();
            Console.WriteLine("Day1 Result1: " + day1_result.ReadFileAndGetMostCalories());
            Console.WriteLine("Day1 Result2: " + day1_result.ReadFileAndGetMostCaloriesForThreeElfs());
        }

        static void Day2Method()
        {
            Day2 day2_result = new Day2();
            Console.WriteLine("Day2 Result1: " + day2_result.ReadFileAndGetScoreWithStrategyGuide(1));
            Console.WriteLine("Day2 Result2: " + day2_result.ReadFileAndGetScoreWithStrategyGuide(2));
        }










    }
}