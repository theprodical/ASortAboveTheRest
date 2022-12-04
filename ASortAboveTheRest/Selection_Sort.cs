using System;
using System.Collections;

namespace ASortAboveTheRest
{
    public class Selection_Sort
    {
        public static void SelectionSort()
        {
            int count = 0;
            int array_size = 10;
            int[] intArray = new int[10];
            int n = intArray.Length;

            Console.WriteLine("Enter 10 Array Elements : ");
            for (int x = 0; x < n; x++)
            {
                intArray[x] = int.Parse(Console.ReadLine());
            }

            int tmp, min_key;

            for (int j = 0; j < array_size - 1; j++)
            {
                count = count + 1;
                min_key = j;

                for (int k = j + 1; k < array_size; k++)
                {
                    if (intArray[k] < intArray[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = intArray[min_key];
                intArray[min_key] = intArray[j];
                intArray[j] = tmp;
            }

            Console.WriteLine("The Array After Selection Sort is: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(intArray[i]);
                
            }
            Console.WriteLine("The Loop iterates: " + count);
            Console.ReadLine();
        }
    }
}