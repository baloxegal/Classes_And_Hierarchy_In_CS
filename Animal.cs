using System;

namespace Classes_Hierarchy_In_CS
{
    abstract class Animal
    {
        string Name
        {
            get;
        }
        string Sound
        {
            get;
        }
        bool Plant_Eating
        {
            get;
        }
        bool Feeds_On_Its_Own
        {
            get;
        }
        public Animal(string name, string sound, bool plant_eating, bool feeds_on_its_own)
        {
            Name = name;
            Sound = sound;
            Plant_Eating = plant_eating;
            Feeds_On_Its_Own = feeds_on_its_own;
        }
        public abstract string Task();
        public override string ToString()
        {
            return "Name: " + Name + " Sound: " + Sound + " Plant eating " + Plant_Eating + " Feeds on it own " + Feeds_On_Its_Own;
        }
    }
}
