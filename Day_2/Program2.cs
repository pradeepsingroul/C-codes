
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class Program2
    {
         public static void Main(string[] args)
        {
            Car car = new Car();
            car.brand = "Thar";
            car.Model = "4*4";
            car.year = 2019;
            Console.WriteLine(car.brand);
            car.accelerate();
            car.carCondition();
        }
        /*
        Object-Oriented Programming with C#
        -Object-oriented programming (OOP) is a programming paradigm that organizes code around objects, which are instances of classes. OOP promotes concepts such as encapsulation, inheritance, and polymorphism to create modular, reusable, and maintainable code.
        */

        /*
        classes and objects in C#
        classes - A class is a blueprint or template for creating objects. It defines the properties (attributes) and behaviors (methods) that objects of that class possess.
        Objects - Objects are instances of classes. They represent individual entities that can be created, manipulated, and interacted with.
        
        Encapsulation  Inheritence polymorphism
        - Encapsulation is the process of bundling data and moethods together with in a class , hiding the internal implementation details from outside the world. It help achieve data abstraction and provide controll over access the class member.
        - Inheritence allow one class to inherit properties and members from another class, establishing a parent-child relationship. The derives class can reuse and extends the functionality of the base class.
        - polymorphism allows object of different class to be treated ans object of a common base class. It provide flexibility and extensibility, enabling methods to be overridden and objects to exhibit different behaviours based on their specific class implementation.
        */


        
    }
}