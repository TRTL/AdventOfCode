using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_03
{
    internal class Day3
    {
        public string[] values = new string[]
        {
            "0",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        public int RucksackCompartments(int taskNo)
        {
            int score = 0;
            string compartment1 = "";
            string compartment2 = "";
            string rucksack1 = "";
            string rucksack2 = "";
            string rucksack3 = "";

            using StreamReader sr = new StreamReader("../../../Day_03/input.txt");
            string newLine;

            while ((newLine = sr.ReadLine()) != null)
            {

                if (taskNo == 1) // Task1
                {
                    string inBoth = "";
                    int middle = (newLine.Length)/2;
                    compartment1 = newLine.Substring(0, middle);
                    compartment2 = newLine.Substring(middle);

                    inBoth = FindRepeatingLetterIn(compartment1, compartment2);
                    score += Array.IndexOf(values, inBoth);
                }
                else // Task2
                {
                    string badge = "";

                    if (rucksack1 == "")
                        rucksack1 = newLine;
                    else if (rucksack2 == "")
                        rucksack2 = newLine;
                    else if (rucksack3 == "")
                        rucksack3 = newLine;

                    if (rucksack1 != "" && rucksack2 != "" && rucksack3 != "")
                    {
                        badge = FindRepeatingLetterIn(rucksack1, rucksack2, rucksack3);
                        score += Array.IndexOf(values, badge);
                        rucksack1 = rucksack2 = rucksack3 = "";
                    }
                }
            }
            return score;
        }

        private static string FindRepeatingLetterIn(string compartment1, string compartment2)
        {
            foreach (char c1 in compartment1)
            {
                foreach (char c2 in compartment2)
                {
                    if (c1 == c2) return c1.ToString();
                }
            }
            return "";
        }

        private static string FindRepeatingLetterIn(string rucksack1, string rucksack2, string rucksack3)
        {
            string foundInAllThreeRucksacks = "";
            foreach (char r1 in rucksack1)
            {
                foreach (char r2 in rucksack2)
                {
                    if (r1 == r2)
                    {
                        foreach(char r3 in rucksack3)
                            if (r1 == r3) foundInAllThreeRucksacks = r1.ToString();
                    }
                }
            }
            return foundInAllThreeRucksacks;
        }
    }
}
