using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_02
{
    internal class Day2
    {

        public int ReadFileAndGetScoreWithStrategyGuide(int taskNo)
        {
            int score = 0;
            using StreamReader sr = new StreamReader("../../../Day_02/input.txt");
            string newLine;

            while ((newLine = sr.ReadLine()) != null && newLine != "")
            {

                string[] moves = newLine.Split(" ");
                string oponentSign = ConvertLetterToSign(moves[0]);
                string mySign = "";

                if (taskNo == 1) mySign = ConvertLetterToSign(moves[1]);
                else mySign = ConvertLetterToSignWithUltraTopSecretStrategyGuide(moves[1], oponentSign);

                score += GetScoreForSign(mySign);
                if (IsWin(oponentSign, mySign)) score += 6;
                if (IsDraw(oponentSign, mySign)) score += 3;
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

        private string ConvertLetterToSignWithUltraTopSecretStrategyGuide(string myLeter, string oponentSign)
        {
            // X means you need to lose
            // Y means you need to end the round in a draw
            // Z means you need to win
            if (myLeter == "X") return LosingMove(oponentSign);
            else if (myLeter == "Y") return oponentSign;
            else return WiningMove(oponentSign);
        }

        private string LosingMove(string oponentSign) => oponentSign switch
        {
            "Rock" => "Scissors",
            "Paper" => "Rock",
            "Scissors" => "Paper",
            _ => throw new NotImplementedException()
        };

        private string WiningMove(string oponentSign) => oponentSign switch
        {
            "Rock" => "Paper",
            "Paper" => "Scissors",
            "Scissors" => "Rock",
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
