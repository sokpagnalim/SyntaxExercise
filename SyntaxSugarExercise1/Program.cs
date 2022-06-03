using System;

namespace SyntaxSugarExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the following code, change the code to implement:
            //inferred typing
            //string interpolation
            //and the ternary operator
            //int answer=4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}

         
            var answer =  4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer}is greater than nine";
            Console.WriteLine(response);
            
        }
    }
}
