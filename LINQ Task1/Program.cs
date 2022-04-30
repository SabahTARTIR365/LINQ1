// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using System.Linq;

namespace LINQTask1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            IEnumerable<int> numbers = new[] { 1, 2, 3, 4, 5 };
            IEnumerable<int> squares = new[] { 1, 4, 9, 16, 25 };
            Console.WriteLine(FullExercise1.TestForSquares(numbers, squares));
        }
    }
    class FullExercise1
    {
        // The following method should return true if each element in the squares sequence
        // is equal to the square of the corresponding element in the numbers sequence.
        // Try to write the entire method using only LINQ method calls, and without writing
        // any loops.
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {

         
         
            return numbers.Select(val => val * val).SequenceEqual(squares);

        }
    }
}

