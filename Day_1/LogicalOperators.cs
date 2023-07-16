using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_1
{
    public class LogicalOperators
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter you number :");
            String strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            if(number%3==0 && number%5==0){
                Console.WriteLine($"The number is {number} is divisible by both 3 and 5.");
            }else if(number%3==0 || number%5==0){
                Console.WriteLine($"The number {number} is divible by 3 or 5.");
            }else{
                Console.WriteLine($"The number {number} is not divible by both 3 or 5.");
            }
        }
    }
}