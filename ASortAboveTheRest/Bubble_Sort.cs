using System;

namespace ASortAboveTheRest
{
    public class Bubble_Sort
    {
        public static void BubbleSort()
        {
            int count = 0;
            int[] intArray = new int[10];

            Console.WriteLine("Enter 10 Array Elements : ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            //Sorting the array
            for (int j = 0; j <= intArray.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    count = count + 1;
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Loop iterates: " + count);
            Console.ReadKey();

        }
    }
}
