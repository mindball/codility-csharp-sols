using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = Solution(new int[] {3, 1, 2, 4, 3 });
        }

        public static int Solution(int[] A)
        {
            int minDifference = 0;
            int SumOfleftSideArray = A[0];
            int SumOfRightSideArray = A[1];

            for (int i = 2; i < A.Length; i++)
            {
                SumOfRightSideArray += A[i];
            }

            minDifference = Math.Abs(SumOfleftSideArray - SumOfRightSideArray);

            for (int i = 1; i < (A.Length - 1); i++)
            {
                SumOfleftSideArray += A[i];
                SumOfRightSideArray -= A[i];

                if(minDifference > Math.Abs(SumOfleftSideArray - SumOfRightSideArray))
                    minDifference = Math.Abs(SumOfleftSideArray - SumOfRightSideArray);
            }

            return minDifference;
        }
    }
}
