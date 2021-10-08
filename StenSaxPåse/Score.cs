using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StenSaxPåse
{
    class Score
    {

        public int _scorePlayer = 1;
        public int _scoreComputer = 1;
        public int PlayerScore
        {
            get => _scorePlayer;
            set => _scorePlayer = value;
        }

        public int ComputerScore
        {
            get => _scoreComputer;
            set => _scoreComputer = value;
        }
    }
}
