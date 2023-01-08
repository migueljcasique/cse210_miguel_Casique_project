using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What was your course grade percentage? ");
      String courseGrade= Console.ReadLine();
      int coursePercent = int.Parse(courseGrade);

      string grade= "";

      if (coursePercent >= 90)
      {
          grade= "A";
      }
      else if (coursePercent >= 80)
      {
          grade = "B";
      }
      else if (coursePercent >= 70)
      {
          grade = "C";
      }
      else if (coursePercent >= 60)
      {
          grade = "D";
      }
      else
      {
          grade = "F";
      }
      Console.WriteLine($"Your final grade is: {grade}");
      if (coursePercent >= 70)
      {
          Console.WriteLine("Congratulations, you passed the course!!!");
      }
      else
      {
          Console.WriteLine("You can do it better next time!!!");
      }    
    }
}