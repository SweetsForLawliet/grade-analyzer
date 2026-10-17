using System;
class Program
{
    static void Main(string[] args)
    {
        ScoreEnteringClass.GradeAnalyzer();
    }
}
public class ScoreEnteringClass
{
    public static void GradeAnalyzer()
    {
        Console.WriteLine("=== Simple Grade Analyzer ===");
        Console.WriteLine("How many test scores do you want to enter?");
        var totalTests = Convert.ToInt32(Console.ReadLine());

        double sum = 0;
        
        for (int test = 1; test <= totalTests; test++) 
        {
            Console.WriteLine("Enter score for test" + test + "(0-100)");
            var score = Convert.ToInt32(Console.ReadLine());

            if( score >= 0 && score <= 100)
            {
                sum += score;
            }
            else
            {
                Console.WriteLine("Invalid score! Please try again.");
                return;
            }
        }
        
         double average = sum / totalTests;
        Console.WriteLine("Your average score is: " + average);

        if (average >= 60)
        {
          Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Try again!");
        }
    }
}
