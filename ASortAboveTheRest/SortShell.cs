using System;
using System.Collections;

namespace ASortAboveTheRest
{
    public class SortShell
    {

        public static void shellSort()
        {
            int count = 0;
            int[] intArray = new int[10];

            Console.WriteLine("Enter 10 Elements : ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            
            //int array_size = 0;
            int x, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (x = 0; x < intArray.Length; x++)
                {
                    count = count + 1;
                    j = x;
                    temp = intArray[x];
                    while ((j >= inc) && (intArray[j - inc] > temp))
                    {
                        intArray[j] = intArray[j - inc];
                        j = j - inc;
                    }
                    intArray[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");                
            }
            Console.WriteLine(" ");
            Console.WriteLine("The Loop iterates: " + count);
            Console.WriteLine(" ");
            Console.ReadKey();
        }  

    }
}