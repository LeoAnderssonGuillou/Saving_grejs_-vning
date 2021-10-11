using System;
using System.Threading;

public class Utilities
{
    public static void WriteNice(string text)
    {
        char[] textArray = text.ToCharArray();
        foreach (char ch in textArray)
        {
            Console.Write(ch);
            Thread.Sleep(10);
        }

        Console.WriteLine();
    }


    public static int GetValidInput()
    {
        int value = 1;
        bool success = false;
        while (!success)
        {
            success = int.TryParse(Console.ReadLine(), out value);
            if (success == false || value < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positve integer");
                success = false;
            }
        }
        return value;
    }

    public static int GetValidChoice()
    {
        int value = 1;
        bool success = false;
        while (!success)
        {
            success = int.TryParse(Console.ReadLine(), out value);
            if (success == false || value < 1 || value > 2)
            {
                Console.WriteLine("Invalid input. Please enter a number 1-2");
                success = false;
            }
        }
        return value;
    }
}