using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_27
{
    class Colors
    {
        public float Red { get; set; }

        public float Blue
        {
            get => Red;
            set => Red = value;
        }

        public Colors(float blue, float red)
        {
            Red = red;
            Blue = blue;
        }

    }
}
