using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int sol = Solution(new int[] {9999999});            
        }

        public static int Solution(int[] A)
        {
            int missInt = 1;
            Array.Sort(A);          

            for (int i = 0; i < A.Length; i++)
            {                
                if(A[i] > 0)
                {
                    if (missInt == A[i])
                        missInt++;
                }
            }

            return missInt;
           
           
        }
    }
}
