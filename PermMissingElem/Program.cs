using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = solution(new int[] { 1, 3, 4, 5, 6, 7, 8 });
        }

        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int result = 0;
            int number = A.Length + 1;
            for (int i = 0; i < A.Length; i++)
            {
                result = result ^ A[i];
            }
            for (int i = 1; i <= number; i++)
            {
                result = result ^ i;
            }

            return result;
        }
    }
}
