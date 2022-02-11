using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZoombinisEnvRes
{
    class Zoombini : IClickable
    {
        //Traits
        public string Name
        { set; get; }
        public NoseColor Nose
        { set; get; }
        public EyeType Eyes
        { set; get; }
        public Hairstyle Hair
        { set; get; }
        public FootType Feet
        { set; get; }

        //States
        public Location CurrentLocation
        { 
            private set {}
            get
            {
                Location location = null;
                foreach (var entry in Globals.locationDict)
                {
                    var l = entry.Value;
                    if (l.ZoombinisAt.Contains(this))
                    {
                        location = l;
                        break;
                    }
                }
                return location;
            }
        }

        //For Drawing
        public Texture2D Texture
        { set; get; }

        public Vector2 Position
        { set; get; }

        //Constructor
        public Zoombini(NoseColor noseColor, EyeType eyes, Hairstyle hair, FootType feet, string name)
        {
            this.Nose = noseColor;
            this.Eyes = eyes;
            this.Hair = hair;
            this.Feet = feet;

            this.Name = name;

            Globals.locationDict[Locations.Docks].ZoombinisAt.Add(this);
            Globals.currentSave.extantZoombinis.Add(this);
        }

        //Methods
        public void Move(Location l)
        {
            l.ZoombinisAt.Add(this); 
            CurrentLocation.ZoombinisAt.Remove(this);
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}