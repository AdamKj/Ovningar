using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StenSaxPåse
{
    class Score
    {

        public int _score = 1;
        public int CurrentScore
        {
            get => _score;
            set => _score = value;
        }
    }
}
