using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool HasScales { get; set; }

        public bool Amphibious { get; set; }

        public int NumberOfTeeth { get; set; }

        public string TypeofCamo { get; set; }

    public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool backbone, bool hasscales, bool amphibious, int numberofteeth, string typeofcamo)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Backbone = backbone;
            HasScales = hasscales;
            Amphibious = amphibious;
            NumberOfTeeth = numberofteeth;
            TypeofCamo = typeofcamo;
        }

    }

}
