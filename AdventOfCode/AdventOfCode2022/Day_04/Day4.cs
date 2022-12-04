using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_04
{
    internal class Day4
    {

        public int OverlapingPairs(int taskNo)
        {
            int score = 0;
            using StreamReader sr = new StreamReader("../../../Day_04/input.txt");
            string newLine;

            while ((newLine = sr.ReadLine()) != null)
            {
                int firstPair1 = Convert.ToInt32(newLine.Split(",")[0].Split("-")[0]);
                int firstPair2 = Convert.ToInt32(newLine.Split(",")[0].Split("-")[1]);
                int secondPair1 = Convert.ToInt32(newLine.Split(",")[1].Split("-")[0]);
                int secondPair2 = Convert.ToInt32(newLine.Split(",")[1].Split("-")[1]);

                    Console.Write($"{firstPair1}-{firstPair2} {secondPair1}-{secondPair2} = ");
                if (taskNo == 1) // TASK 1 // 599
                {
                    if (IsFirstPairInsideoOfSecondPair(firstPair1, firstPair2, secondPair1, secondPair2))
                    {
                        score++;
                        Console.WriteLine($"YES (first inside second)");
                    }
                    else if (IsSecondPairInsideOfFirstPair(firstPair1, firstPair2, secondPair1, secondPair2))
                    {
                        score++;
                        Console.WriteLine($"YES (second inside first)");
                    }
                    else
                        Console.WriteLine($"NOPE");
                }
                else // TASK 2 // 916 // 672 // 928
                {
                    if (DoPairsOverlap(firstPair1, firstPair2, secondPair1, secondPair2))
                    {
                        score++;
                        Console.WriteLine($"YES (pairs overlap)");
                    }
                    else
                        Console.WriteLine($"NOPE");
                }
            };

            return score;
        }

        private bool IsFirstPairInsideoOfSecondPair(int first1, int first2, int second1, int second2) =>
            first1 >= second1 && first2 <= second2;

        private bool IsSecondPairInsideOfFirstPair(int first1, int first2, int second1, int second2) =>
            second1 >= first1 && second2 <= first2;

        private bool DoPairsOverlap(int first1, int first2, int second1, int second2) =>
            first1 == second1 ||
            first2 == second2 ||
            first1 == second2 ||
            first2 == second1 ||
            first1 < second1 && first1 < second2 && first2 > second1 && first2 > second2 ||
            first1 > second1 && first1 < second2 && first2 > second1 && first2 < second2  ||
            first1 < second1 && first1 < second2 && first2 > second1 && first2 < second2  ||
            first1 > second1 && first1 < second2 && first2 > second1 && first2 > second2;

        /*
        ...4567..  4-7
        ...456...  4-6

        ..3456...  4-6
        ...456...  4-6

        .....67..  6-7
        ...456...  4-6

        ....567..  5-7
        ......789  7-9

        .2345678.  2-8
        ..34567..  3-7

        ....56...  5-6
        ...45678.  4-8    

        .23456...  2-6
        ...45678.  4-8    

        ...45678.  4-8
        .23456...  2-6        
         */
    }
}
