using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_26
{
    class StepCounter
    {
        public int Steps { get; private set; }

        public void Step()
        {
            Console.WriteLine($"Steg {Steps}");
            Steps++;
        }

        public void Reset()
        {
            Steps = 0;
            Console.WriteLine($"Stegen är nu nollställda");
            Console.WriteLine($"Steg {Steps}");
        }
    }
}
