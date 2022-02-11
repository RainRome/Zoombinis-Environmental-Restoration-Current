using System.Collections.Generic;

namespace ZoombinisEnvRes
{
    static class Globals
    {
        public static Dictionary<Locations, Location> locationDict = new Dictionary<Locations, Location>()
        {
            {Locations.Zoombiniville, new Location()},
            {Locations.Docks, new Location()},
            {Locations.Chutes, new Location()}
        };

        public static SaveData currentSave = new SaveData();
    }
}