using System;

namespace Saving_grejs_övning
{
    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int PowerLevel { get; set; }

        public Character(string name, string species, int power)
        {
            Name = name;
            Species = species;
            PowerLevel = power;
        }
    }
}