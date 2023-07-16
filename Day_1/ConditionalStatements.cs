using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_1
{
    public class ConditionalStatements
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            String strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            if(number>0){
                Console.WriteLine($"The number {number} is positive");
            }else if(number==0){
                Console.WriteLine($"The number {number} is zero");
            }else{
                Console.WriteLine($"The number {number} is negative");

            }
        }
        
    }
}