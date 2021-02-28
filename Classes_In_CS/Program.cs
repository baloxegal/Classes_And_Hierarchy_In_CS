using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_In_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            RoadSign SpeedLimit60Km = new RoadSign("Speed limit is 60 km. h", "You cann't move with a speed exceeding 60 km. h", true);
            Console.WriteLine(SpeedLimit60Km.ToString());
            Console.WriteLine(SpeedLimit60Km.Action());

            RoadSign RoadClosed = new RoadSign("Road closed", "You cann't move by this road", false, "Cargo", "The sign applies only to cargo transport");
            Console.WriteLine(RoadClosed.ToString());
            Console.WriteLine(RoadClosed.Action());

            Semafor threeLightsSemafor = new Semafor("Semafor", "Vehicle travel is regulated depending on the color of the traffic light");
            Console.WriteLine(threeLightsSemafor.ToString());
            threeLightsSemafor.SwitchSemaforColor(5000);
        }
    }
}
