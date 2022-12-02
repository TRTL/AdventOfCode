using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_1
{
    public class Day1
    {
        public int mostCalories = 0;
        private int top1ElfsCalories = 0;
        private int top2ElfsCalories = 0;
        private int top3ElfsCalories = 0;

        public int ReadFileAndGetMostCalories()
        {
            using StreamReader sr = new StreamReader("../../../Day_1/input.txt");
            string newLine;
            int newCalories = 0;

            while ((newLine = sr.ReadLine()) != null)
            {
                if (newLine != "")
                    newCalories += Convert.ToInt32(newLine);
                else
                {
                    if (newCalories > mostCalories &&
                        newCalories != top1ElfsCalories &&
                        newCalories != top2ElfsCalories)
                        mostCalories = newCalories;
                    newCalories = 0;
                }
            }
            return mostCalories;
        }


        public int ReadFileAndGetMostCaloriesForThreeElfs()
        {
            using StreamReader sr = new StreamReader("../../../Day_1/input.txt");
            string newLine;

            top1ElfsCalories = ReadFileAndGetMostCalories();
            mostCalories = 0;
            top2ElfsCalories = ReadFileAndGetMostCalories();
            mostCalories = 0;
            top3ElfsCalories = ReadFileAndGetMostCalories();

            return  top1ElfsCalories + top2ElfsCalories + top3ElfsCalories;
        }

    }
}
