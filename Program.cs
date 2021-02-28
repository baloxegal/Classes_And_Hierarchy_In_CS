using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Hierarchy_In_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow("burenka", "muuuu", true, true);
            Console.WriteLine(cow.ToString());
            Console.WriteLine(cow.Task("noon"));

            Dog dog = new Dog("sharic", "gav", false, false);
            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog.Task());
        }
    }
}
