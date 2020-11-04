using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool Wings { get; set; }

        public string Beak { get; set; }

        public bool Feathers { get; set; }

        public bool HollowBones { get; set; }

        public Bird()
        {

        }

        public Bird(string name, int age, int legs, bool backbone, bool wings, string beak, bool feathers, bool hollowbones)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Backbone = backbone;
            Wings = wings;
            Beak = beak;
            Feathers = feathers;
            HollowBones = hollowbones;
        }





    }
}
