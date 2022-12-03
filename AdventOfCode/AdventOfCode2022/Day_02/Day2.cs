using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_02
{
    internal class Day2
    {

        public int ReadFileAndGetScoreWithStrategyGuide()
        {
            int score = 0;
            using StreamReader sr = new StreamReader("../../../Day_02/input.txt");
            string newLine;

            while ((newLine = sr.ReadLine()) != null && newLine != "")
            {

                string[] moves = newLine.Split(" ");
                string oponentSign = ConvertLetterToSign(moves[0]);
                string mySign = ConvertLetterToSign(moves[1]);

                score += GetScoreForSign(mySign);
                if (IsWin(oponentSign, mySign)) score += 6;
                if (IsDraw(oponentSign, mySign)) score += 3;
                Console.WriteLine(score);

            }
            return score;
        }

        public string ConvertLetterToSign(string letter) => letter switch
        {
            "A" or "X" => "Rock",
            "B" or "Y" => "Paper",
            "C" or "Z" => "Scissors",
            _ => throw new NotImplementedException()
        };


        private int GetScoreForSign(string sign) => sign switch
        {
            "Rock" => 1,
            "Paper" => 2,
            "Scissors" => 3,
            _ => throw new NotImplementedException()
        };

        private bool IsWin(string oponentSign, string mySign) => oponentSign == "Rock" && mySign == "Paper" ||
                                                                 oponentSign == "Paper" && mySign == "Scissors" ||
                                                                 oponentSign == "Scissors" && mySign == "Rock";

        private bool IsDraw(string oponentSign, string mySign) => oponentSign ==  mySign;
    }
}
