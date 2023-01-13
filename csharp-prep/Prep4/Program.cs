using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        String sInput;
        int userInput;
        Console.WriteLine("Enter a list of numbers,type 0 when finished.");
        while (true)
        {
            Console.Write("Enter a number: ");
            sInput= Console.ReadLine();
            userInput= int.Parse(sInput);
            if (userInput == 0)
            {
                break;
            }
            numbers.Add(userInput);
        }
        int listSum = numbers.Sum();
        Console.WriteLine($"The sum is : {listSum}");
        int listTotal= numbers.Count();
        int listAvg = listSum/listTotal;
        Console.WriteLine($"The average is: {listAvg}");
        int largestValue= numbers.Max();
        Console.WriteLine($"The largest number is: {largestValue}");
    }
}