using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int d = 1;

            int stepToGoY = y - x;
            int countOfSteps = stepToGoY / d;

            //Add one more step
            if (stepToGoY % d != 0) countOfSteps++;

            Console.WriteLine(countOfSteps);

        }
    }
}
