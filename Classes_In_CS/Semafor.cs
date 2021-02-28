using System;
using System.Threading;

namespace Classes_In_CS
{
    class Semafor : AbstractRoadSign
    {
        public Color State
        {
            get;
            set;           
        }
        public enum Color
        {
            RED, YELLOW, GREEN
        }
        public Semafor(string name, string description) : base(name, description)
        {
        }
        public override string Action()
        {
            if (this.State == Color.RED)
                return this.ProhibitsAction();
            else
                return this.PermitsAction();
        }
        public void SwitchSemaforColor(int timeout)
        {
            while (true)
            {
                foreach(Color a in Enum.GetValues(typeof(Color)))
                { 
                    if(State == Color.GREEN)
                    {
                        Console.WriteLine(State = Color.YELLOW);
                        Console.WriteLine(this.Action());
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine(State = a);
                    Console.WriteLine(this.Action());
                    if (a == Color.YELLOW)
                    {
                        Thread.Sleep(1000);
                        continue;
                    }                    
                    Thread.Sleep(timeout);
                }
            }
        }
        public void SwitchSemaforColor(Color color)
        {
            Console.WriteLine(State = color);
            Console.WriteLine(this.Action());
        }
        public override string PermitsAction()
        {
            if(this.State == Color.YELLOW)
                return "Continue very carefully, or make sure not to interfere with the movement of others";
            else
                return base.PermitsAction();

        }       
    }
}
