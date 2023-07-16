using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_1
{
    public class ArthmaticOperator
    {
         public static void Main(string[] args)
        {
             Console.WriteLine("Enter your first Number :");
            String fNumber = Console.ReadLine();
            int a = int.Parse(fNumber);

            Console.WriteLine("Enter your second Number :");
            String sNumber = Console.ReadLine();
            int b = int.Parse(sNumber);

            int sum = add( a, b);
            Console.WriteLine($"Addtion:{a} + {b} = {sum}");
        
            int subs = substract( a, b);
            Console.WriteLine($"Subtraction:{a} - {b} = {sum}");
        
            int mult = multiply( a, b);
            Console.WriteLine($"Multiplication:{a} * {b} = {mult}");

            double dvd = divide( a, b);
            Console.WriteLine($"Division:{a} / {b} = {dvd}");
        }


        //it will add a to b;
        public static int add(int a,int b){
            return a+b;
        } 

        //it will substract a to b;
        public static int substract(int a,int b){
            return a-b;
        } 

        //it will multiply a to b;
        public static int multiply(int a,int b){
            return a*b;
        } 


        //it will divide a to b;
        public static double divide(int a,int b){
            return a/b;
        } 
    }
}