using System;

namespace MethodsExercise
{
    internal class Program
    {
// Exercise 2
        //Method Definition
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Product(int x, int y)
        {
            return x * y;
        }

        public static int Quotient(int x, int y)
        {
            return x / y;
        }
  
 //Params Challenge Definition
        public static int paramsChallenge(params int [] sums)
        {
            int total = 0;

            foreach (int sum in sums)
            {
                total = total + sum;
            }
            return total;
        }

        static void Main(string[] args)
        {
            // Method Call
            Console.WriteLine(Program.Sum(5, 5));
            Console.WriteLine(Program.Sub(30, 10));
            Console.WriteLine(Program.Product(10, 3));
            Console.WriteLine(Program.Quotient(400, 10));
            Console.WriteLine();
            // Challenge params
            Console.WriteLine(Program.paramsChallenge(1, 2, 3, 4, 5));
        }
    }
}
