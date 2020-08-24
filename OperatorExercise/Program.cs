using System;

namespace OperatorExercise
{
    class Program
    {
        public static void Addition (int a , int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void Subtraction(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine($"The difference of {a} and {b} is {diff}.");
        }
        public static void Multiplication(int a, int b)
        {
            int product = a * b;
            Console.WriteLine(product);
        }
        public static void Division(int a, int b)
        {
            double quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
        }

        public static void AreaOfCircle(double r)
        {
            double a = r * r * Math.PI;
            Console.WriteLine($"The area of a circle with radius of {r} is {a}.");    
        }



        static void Main(string[] args)
        {
            Division(58, 5);
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
                        

        }
    }
}
