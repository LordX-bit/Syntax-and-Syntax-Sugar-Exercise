using System.Runtime.CompilerServices;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // inferred typing
            //int answer = 4;
            // string response;

            //if (answer < 9)
            {
                // response = answer + " is less than nine";
            }
            //else
            {
                // response = answer + "greater than or equal to nine";
            }

            //Console.WriteLine(answer);
           
            
            
            
            
            
            // Ternary Operator
            //var answer = 4;
            //var response = (9 > answer) ? " is less than nine " : "  is great than or equal to nine";
            
            //Console.WriteLine(answer + response);

            
            
            
            
            
            
            
            //String interpolation
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";


            Console.WriteLine( response);




        }
    }
}
