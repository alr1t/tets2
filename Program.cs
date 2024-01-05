using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class ArrayRange2
{
    static void Main()
    {
        string input = Console.ReadLine();
        int numberOfellements = int.Parse(input);
        int min = 1;
        int max = 26;

        Random random = new Random();

        int[] arrayA = new int[numberOfellements];
        int[] arrayEven = new int[numberOfellements];
        int[] arrayOdd = new int[numberOfellements];

        for (int i = 0; i < numberOfellements; i++)
        {
            arrayA[i] = random.Next(min, max);
        }
        
        Console.WriteLine("Generated Massive");
        foreach (int num in arrayA)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
        
        int countwithout0 = 0;
        int count = 0;
        foreach (int num in arrayA)
        {
            if (num % 2 == 0)
            {
                arrayEven[count] = num;
                count++;
                countwithout0++;


            }
        }
        Console.WriteLine("Even massavi");

        int[] arrayEvenRed = new int[countwithout0];
        count = 0;

        foreach (int num in arrayEven)
        {
            if (num != 0)
            {
                arrayEvenRed[count] = num;
                count++;
            }
        }

        foreach (int num in arrayEvenRed)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Odd massavi");

        countwithout0 = 0;
        count = 0;

        foreach (int num in arrayA)
        {
            if (num % 2 != 0)
            {
                arrayOdd[count] = num;
                count++;
                countwithout0++;

            }
        }

        int[] arrayOddRed = new int[countwithout0];
        count = 0;

        foreach (int num in arrayOdd)
        {
            if (num != 0)
            {
                arrayOddRed[count] = num;
                count++;
            }
        }
        foreach(int num in arrayOddRed)
        {
            Console.WriteLine(num);
        }      

        static void AlphabicationSort(int[] array)
        {

            int count1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] == 1) || (array[i] == 5) || (array[i] == 9) || (array[i] == 8) || (array[i] == 10) || (array[i] == 4))
                {
                    array[i] = 'A' + array[i] - 1;
                    count1++;
                }
                else array[i] = 'a' + array[i] - 1;
            }
            Console.WriteLine(count1); 
        }

    
        //output
        Console.WriteLine("Alphabicated");
        Console.WriteLine();
        Console.WriteLine("Number of uppercase letters in Even:");
        AlphabicationSort(arrayEvenRed);
        Console.WriteLine("Number of uppercase letters in Odd:");
        AlphabicationSort(arrayOddRed);
        Console.WriteLine("AlphabicatedOdd");

        foreach (var item in arrayOddRed)
        {
            Console.Write((char)item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("AlphabicatedEven");

        foreach (var item in arrayEvenRed)
        {
            Console.Write((char)item + " ");
        }
       


    }

}