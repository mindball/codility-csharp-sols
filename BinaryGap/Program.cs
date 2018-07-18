using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);           
            
            if (number == 0 || number == 1 || number == 2
                        || number == 3 || number == 4)
                Console.WriteLine(0);
            else
                Console.WriteLine(BinaryGap(number));
        }

        public static int BinaryGap(int number)
        {
            int currentCountConZeros = 0;
            int maxCountConZers = 0;
            int tempNumber = 0;

            while (number > 0)
            {
                if (number == 1)
                {
                   break;
                }
                //looking for  first One (or odd number)
                else if (number % 2 != 0)
                {
                    tempNumber = number / 2;

                    while (tempNumber % 2 == 0)
                    {
                        currentCountConZeros++;
                        tempNumber /= 2;
                    }
                    if (maxCountConZers < currentCountConZeros)
                        maxCountConZers = currentCountConZeros;
                                
                    number = tempNumber;
                    currentCountConZeros = 0;

                }                
                
                else
                {
                    number /= 2;
                }
                
                

            }

            return maxCountConZers;

        }

        

       
    }
}
