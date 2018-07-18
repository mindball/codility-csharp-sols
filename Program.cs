using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 1, 2, 1, 2, 4, 5, 6 };
            var s1 = Stopwatch.StartNew();
            Console.WriteLine(Solution1(array));
            s1.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
            100000000).ToString("0.00 ns"));

            var s2 = Stopwatch.StartNew();
            Console.WriteLine(Solution2(array));
            s2.Stop();
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
            100000000).ToString("0.00 ns"));
        }

        private static int Solution1(int[] array)
        {
            bool[] passingIndex = new bool[array.Length];
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (passingIndex[i] != true)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (passingIndex[j] != true)
                        {
                            if (array[i] == array[j])
                            {
                                passingIndex[i] = true;
                                passingIndex[j] = true;
                                break;
                            }
                        }
                    }
                }

            }

            int result = 0;
            for (int i = 0; i < passingIndex.Length; i++)
            {
                if(passingIndex[i] == false)
                {
                    result = array[i];
                }
            }

            return result;
            
        }

        private static int Solution2(int[] array)
        {
            Dictionary<int, int> occurs = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(occurs.ContainsKey(array[i]) && occurs[array[i]] == 1)
                {
                    occurs.Remove(array[i]);
                }
                else
                {
                    occurs.Add(array[i], 1);
                    
                }
            }
            int result = 0;
            foreach (var item in occurs)
            {
                result = item.Key;
            }
            return result;
        }

        
    }
}
