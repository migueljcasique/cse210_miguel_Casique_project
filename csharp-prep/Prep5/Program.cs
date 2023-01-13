using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        String uname = ProntUserName();
        int favUserNumber = PromtUserNumber();
        double sqtUserNumber = SquareNumber(favUserNumber);
        DisplayResult(uname, sqtUserNumber);
        
    }
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static String ProntUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber= Console.ReadLine();
            int iUserNumber= int.Parse(userNumber);
            return iUserNumber;
        }
        static double SquareNumber(double iUserNumber)
        {
             double sqtNumber= iUserNumber*iUserNumber;
             return sqtNumber;            
        }
        static void DisplayResult(string userName, double sqtNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqtNumber}");
        }
}