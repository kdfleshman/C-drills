using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodDrillOne
{
    class Table

    {
        public int Add(int number)
        {
            int result = number + 150;
            return result;
        }
        public int Subtract(int number)
        {
            int difference = 1000 - number;
            return difference;
        }
        public int Multiply(int number)
        {
            int product = number * 6;
            return product;
        }
    }
}
