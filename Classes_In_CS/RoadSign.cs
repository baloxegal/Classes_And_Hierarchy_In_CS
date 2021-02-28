using System;

namespace Classes_In_CS
{    
    class RoadSign : AbstractRoadSign
    {
        private RoadSign additionalSign;
        public RoadSign AdditionalSign
        {
            get
            {
                return additionalSign;
            }
        }
        private bool? trafficPermission;
        public bool? TrafficPermission
        {
            get
            {
                return trafficPermission;
            }
        }
        public RoadSign(string name, string description, bool trafficPermission, string nameAdditionalSign, string descriptionAdditionalSign) : this(name, description, trafficPermission)
        {
            this.additionalSign = new RoadSign(nameAdditionalSign, descriptionAdditionalSign);
        }
        public RoadSign(string  name, string description, bool trafficPermission) : this(name, description)
        {
            this.trafficPermission = trafficPermission;
        }
        public RoadSign(string name, string description) : base(name, description)
        {            
        }
        public override string Action()
        {
            if (TrafficPermission == null || TrafficPermission == true)
                return this.PermitsAction();
            else
                return this.ProhibitsAction(); 
        }
        public override string ToString()
        {
            if (trafficPermission == null)
                return "It is additional sign: " + base.ToString();
            else if (additionalSign == null)
                return base.ToString() + ", traffic permission is: " + trafficPermission;
            else
                return base.ToString() + ", traffic permission is: " + trafficPermission + ", " + additionalSign.ToString();
        }
    }
}
