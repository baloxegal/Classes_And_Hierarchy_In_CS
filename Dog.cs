using System;

namespace Classes_Hierarchy_In_CS
{
    class Dog : Animal
    {
        public Dog(string name, string sound, bool plant_eating, bool feeds_on_its_own) : base(name, sound, plant_eating, feeds_on_its_own)
        {

        }

        public override string Task()
        {
            return "Guard the yard!";
        }
    }
}
