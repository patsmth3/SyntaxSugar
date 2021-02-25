using System;

namespace SyntaxSugarExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var answer = 4;
            //var response;

            /*if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            Console.WriteLine(response);
            */

            // -----------String Ternary---------------------------

            var response = (answer < 9) ? "is less than nine" : "greater than or equal to nine";
            Console.WriteLine($"{response} {answer}");



        }
    }
}