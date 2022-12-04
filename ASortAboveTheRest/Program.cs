/*
For CS3910-C1 Emerging Programming Languages
Written by James Brumbaugh
For the express purpose of getting an awesome grade 
Date: December 3 2022
*/
using System;
using static ASortAboveTheRest.Selection_Sort;
using static ASortAboveTheRest.Bubble_Sort;
using static ASortAboveTheRest.SortShell;

namespace ASortAboveTheRest
{
    public class Program        
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose a sort algorithm to perform on the Array");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Option 1: Selection Sort");
            Console.WriteLine("Option 2: Bubble Sort");
            Console.WriteLine("Option 3: Shell Sort");
            Console.WriteLine("");
            Console.WriteLine("Please enter your option: 1, 2, or 3");
            string myOption;
            myOption = Console.ReadLine();
            
            switch (myOption)
            {
                case "1":
                    SelectionSort();
                    break;
                case "2":
                    BubbleSort();
                    break;
                case "3":
                    shellSort();
                    break;
                default:
                    break;
            }         

        }        

    }
}
