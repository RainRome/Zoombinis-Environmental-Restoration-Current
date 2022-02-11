using System.Collections.Generic;

namespace ZoombinisEnvRes
{
    class Location
    {
        //Fields
        public List<Zoombini> ZoombinisAt 
        { set; get; }

        //Constructor
        public Location()
        {
            this.ZoombinisAt = new List<Zoombini>();
        }
    }
}