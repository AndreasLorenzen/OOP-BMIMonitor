using System;

namespace OOP_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Andreas",
                LastName = "Lorenzen",
                Weight = 71.0,
                Height = 1.84
            };
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
            Console.WriteLine($"Calculated BMI: {person.BMI:F2}");
        }
    }
}
