using System;

namespace Classes_Hierarchy_In_CS
{
    class Cow : Animal
    {
        public Cow(string name, string sound, bool plant_eating, bool feeds_on_its_own) : base(name, sound, plant_eating, feeds_on_its_own)
        {

        }

        public override string Task()
        {
            return "Milk milk!";
        }
        public string Task(string partOfTheDay)
        {
            if (partOfTheDay.Equals("morning"))
                return Task();
            else if (partOfTheDay.Equals("noon"))
                return "Eat on fields!";
            else if (partOfTheDay.Equals("evening"))
                return Task();
            else
                return "Go to sleep!";
        }
    }
}
