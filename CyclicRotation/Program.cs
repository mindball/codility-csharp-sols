using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] number = { 1, 2, 3, 4, 5, 6,};
            int countOfRotation = 4;
            int[] result = SolutionA(number, countOfRotation);
            

        }

        public static int[] SolutionA(int[] array, int countOfRotation)
        {
            //Use it only to change first and last;
            LinkedList<int> makeOperation = new LinkedList<int>(array);
            int insert;

            for (int i = 1; i <= countOfRotation; i++)
            {
                insert = makeOperation.Last();
                makeOperation.RemoveLast();
                makeOperation.AddFirst(insert);
            }

            array = makeOperation.ToArray();

            return array;
        }

      
    }
}
