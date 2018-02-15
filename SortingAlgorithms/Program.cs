using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int min = -5000;
            int max = 5000;
            Console.WriteLine("Please enter the size of an array that you want to sort");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[intTemp];
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(min, max);
            }
            Util.PrintInfo();
            bool t = true;
            while(t)
            {
                String s = Convert.ToString(Console.ReadLine());
                int[] algorithmNumbers = new int[0];
                if (s.Length == 1)
                {
                    algorithmNumbers = new int[1];
                    algorithmNumbers[0] = Int32.Parse(s);
                    t = false;
                }
                else if (s[1] == ',')
                {
                    int i = 0;
                    algorithmNumbers = new int[s.Split(',').Length];
                    foreach(String number in s.Split(',')){
                        algorithmNumbers[i++] = Int32.Parse(number);
                    }
                    t = false;
                }
                else if (s[1] == '-' && s.Length==3)
                {
                    int i = 0;
                    algorithmNumbers = new int[s.Split('-').Length];
                    String[] inputNumbersOfAlgorithms = s.Split('-');
                    int firstNumberOfAlgorithm = Int32.Parse(inputNumbersOfAlgorithms[0]);
                    int secondNumberOfAlgorithm = Int32.Parse(inputNumbersOfAlgorithms[1]);
                    algorithmNumbers = new int[secondNumberOfAlgorithm - firstNumberOfAlgorithm+1];
                    while(firstNumberOfAlgorithm<=secondNumberOfAlgorithm)
                    {
                        algorithmNumbers[i] = firstNumberOfAlgorithm;
                        i++;
                        firstNumberOfAlgorithm++;
                    }
                    t = false;
                }
                else {
                    Console.WriteLine("Correct input if you like like one algorith select only number(for example 3) " +
                                      "else if you like several algorithms please enter the range of algorithm numbers(for example 1-3)" +
                                      "and finally you can select several algorithm writing their numbers separated by comma (for example 1,3)");
                }
                int[] arr = new int[0];
                foreach(int current in algorithmNumbers){
                    Util.SwithCase(array,current,intTemp);
                }
            }
        }
    }
}
