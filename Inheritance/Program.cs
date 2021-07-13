using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             *
             */
            var eagle = new Bird()
            {
                WingColor = "Black",
                CanFly = true,
                BeakLength = 6.2,
                DoMigrate = true

            };



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var gecko = new Reptile()
            {
                SkinColor = "green",
                IsColdBlooded = true,
                HasScales = false,
                RegenerativeScale = true

            };
            var myAnimal = new Animal[] { eagle, gecko };
            foreach (var animal in myAnimal)
            {
                Console.WriteLine($"It has {animal.LegCount} Legs");
                Console.WriteLine($"It has {animal.Eyes} eyes");
                Console.WriteLine($"It lives close to the {animal.Habitat}");
                Console.WriteLine($"It has {animal.SkinType} covering it's body");
                Console.WriteLine("");
            }
        }
    }
}
