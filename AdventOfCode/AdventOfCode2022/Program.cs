using AdventOfCode2022.Day_1;
using AdventOfCode2022.Day_02;
using AdventOfCode2022.Day_03;
using AdventOfCode2022.Day_04;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Advent of code 2022!");

            //Day1Method();
            //Day2Method();
            //Day3Method();
            Day4Method();

        }

        static void Day1Method()
        {
            Day1 result = new Day1();
            Console.WriteLine("Day1 Result1: " + result.ReadFileAndGetMostCalories());
            Console.WriteLine("Day1 Result2: " + result.ReadFileAndGetMostCaloriesForThreeElfs());
        }

        static void Day2Method()
        {
            Day2 result = new Day2();
            Console.WriteLine("Day2 Result1: " + result.ReadFileAndGetScoreWithStrategyGuide(1));
            Console.WriteLine("Day2 Result2: " + result.ReadFileAndGetScoreWithStrategyGuide(2));
        }

        static void Day3Method()
        {
            Day3 result = new Day3();
            Console.WriteLine("Day3 Result1: " + result.RucksackCompartments(1));
            Console.WriteLine("Day3 Result2: " + result.RucksackCompartments(2));
        }

        static void Day4Method()
        {
            Day4 result = new Day4();
            Console.WriteLine("Day4 Result1: " + result.OverlapingPairs(1));
            Console.WriteLine("Day4 Result2: " + result.OverlapingPairs(2));
        }










    }
}