using System;

namespace BeginClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            var TheCar = new Car();
            TheCar.Make = "Audi";
            TheCar.Model = "A6"; 
             TheCar.Year = 2016;

            Console.WriteLine($"The Year is: {TheCar.Year}");
            Console.WriteLine($"The Make is: {TheCar.Make}");
            Console.WriteLine($"The Model is: {TheCar.Model}");

         }

    }

}
