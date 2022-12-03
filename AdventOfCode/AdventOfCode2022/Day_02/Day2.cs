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
            //using StreamReader sr = new StreamReader("../../../Day_02/input_sample.txt");
            string newLine;

            while ((newLine = sr.ReadLine()) != null)
            {
                string[] moves = newLine.Split(" ");
                string oponentMove = moves[0];
                string myMove = moves[1];

                score += GetRoundScore(oponentMove, myMove); 
                Console.WriteLine(score);

            }
            return score;
        }

        private int GetRoundScore(string oponentMove, string myMove)
        {
            int oponentScore = GetScoreForMove(oponentMove);
            int myScore = GetScoreForMove(myMove);
            int roundScore = 0;

            if (oponentScore > myScore) roundScore = 0;
            if (oponentScore == myScore) roundScore = 3;
            if (oponentScore < myScore) roundScore = 6;
            return myScore + roundScore;
        }

        private int GetScoreForMove(string move)
        {
            int scoreForMove = 0;
            switch (move)
            {
                case "A" or "X":
                    scoreForMove = 1;
                    break;
                case "B" or "Y":
                    scoreForMove = 2;
                    break;
                case "C" or "Z":
                    scoreForMove = 3;
                    break;
            }
            return scoreForMove;
        }
    }
}
