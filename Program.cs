using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_2_3
{
    internal class Maths
    {
        public static int Doingregularmath(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public static decimal Doingdecimalmath(decimal Num1, decimal Num2, decimal Num3)
        {
            return Num1 + Num2 + Num3;
        }
        public static float Doingfloatmath(float Num1, float Num2)
        {
            return Num1 * Num2;
        }
        public static float Doingmorefloatmath(float Num1, float Num2, float Num3)
        {
            return Num1 * Num2 * Num3;
        }

        static void Main(string[] args)
        {
            /*  
              Overloading: Write a simple Maths class (don’t use the keyword Math, it will be a conflict with standard class from system).
                Write overloaded methods with logic and give choice to user to call different methods:
                a. Add(int num1, int num2)
                b. Add(decimal num1, decimal num2, decimal num3)
                c. Multiply(float num1, float num2)
                d. Multiply(float num1, float num2, float num3)
                Declare these methods as public and static.
            */

            double Num1 = (2);
            double Num2 = (2.5);
            double Num3 = (2.75);
            
            Console.WriteLine("Time for arbitrary math:");
            Console.WriteLine("");
            Console.WriteLine("Part A: " + Num1 + Num2);
            Console.WriteLine("Part B: " + Num1 + Num2 + Num3);
            Console.WriteLine("Part C: " + Num1 * Num2);
            Console.WriteLine("Part D: " + Num1 * Num2 * Num3);
        } 
    }
}
////*
/*
//starting to figure it out. Just a little bit.
*/
//Maybe.
