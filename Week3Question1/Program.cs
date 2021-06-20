using System;

namespace Week3Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
          Declair and  initialize array of 10 integers.
          print only the odd numbers.
            */
            int[] array = new int[10];
            int i;
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a array" + i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                {
                    if (array[i] % 2 != 0) ;
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}