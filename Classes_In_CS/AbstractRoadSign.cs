using System;

namespace Classes_In_CS
{
    public abstract class  AbstractRoadSign
    {
        public string Name
        {
            get;
        }
        public string Description
        {
            get;
        }
        public AbstractRoadSign(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual string PermitsAction()
        {
            return "permits traffic";
        }
        public string ProhibitsAction()
        {
            return "prohibits traffic";
        }
        public abstract string Action();
        public override string ToString()
        {
            return "Sign name is a: " + Name + ", " + "Sign description is a: " + Description;
        }
    }
}
