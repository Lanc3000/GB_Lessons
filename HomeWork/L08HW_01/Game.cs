using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08HW_01
{
    public class Game
    {
        private int gameScore;
        private int correctAnswers;
        private List<Question> list;

        public int GameScore
        {
            get { return gameScore; }
            set { gameScore = value; }
        }
        public int CorrectAnswers
        {
            get { return correctAnswers; }
            set { correctAnswers = value; }
        }

    }
}
