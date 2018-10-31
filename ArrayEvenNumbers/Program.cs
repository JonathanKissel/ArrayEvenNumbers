using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] score = { 1, 5, 6, 2, 8, 15, 13, 17, 4, 12 };
                int sum = 0;
                for (int i = 0; i <= 9; i++)
                {
                    if (score[i] % 2 == 0)
                    {
                        sum = sum + score[i];
                    }
                }
                Console.WriteLine("Sum:" + sum);
            }
        }
    }

}
