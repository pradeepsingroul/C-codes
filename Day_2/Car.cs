
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class Car
    {
        public String brand;
        public String Model;
        public int year;

        public Car(String br, String mdl, int yr){
            this.brand = br;
            this.Model = mdl;
            this.year = yr;
        }
        public Car(){
           
        }
        public void carCondition(){
            Console.WriteLine("Runnig condition");
        }
        public void accelerate(){
            Console.WriteLine("car is accelerationg..");
        }

       


    }


}