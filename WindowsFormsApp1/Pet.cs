using System;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Pet
    {
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Pet()
        {
        }
        public Pet(string species, string breed, string color, int age, string gender)
        {
            this.Species = species;
            this.Breed = breed;
            this.Color = color;
            this.Age = age;
            this.Gender = gender;
        }
    }
}