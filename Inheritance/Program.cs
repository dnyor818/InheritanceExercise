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


            Bird Falcon = new Bird("Red", 32, 2, true, true, "Sharp", true, true);

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"{Falcon.Name}, is a bird of prey. {Falcon.Name} is {Falcon.Age} years old, he has {Falcon.Legs} legs" +
                $". Does the Falcon have a backbone, hollow bones, feathers, and what type of beak does he have kids? {Falcon.Backbone}, {Falcon.HollowBones}, {Falcon.Feathers}, {Falcon.Beak}");
            
            Reptile Alligator = new Reptile("Smiley", 8, 4, true, true, true, 232, "Watersnorkel");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"O.K. kids, this is {Alligator.Name}, he's an American Alligator! 'Ohhh, ahhhh'... he's {Alligator.Age} years old, has {Alligator.Legs} legs, has {Alligator.NumberOfTeeth} teeth," +
                $"has {Alligator.TypeofCamo} camo. Does he walk on water and can swim? {Alligator.Amphibious}. Does he have a backbone? {Alligator.Backbone}. Does he have scales? {Alligator.HasScales}");
        }
    }
}
