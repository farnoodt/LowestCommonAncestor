using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreePractice
{
    public  class MaxMin
    {
        public  int Max;
        public int Min;
        public int size;
        public bool IsBTS;

        public MaxMin()
        {
            Max = int.MinValue;
            Min = int.MaxValue;
            size = 0;
            IsBTS = true;
        }
    }
}
