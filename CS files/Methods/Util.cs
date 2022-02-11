using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ZoombinisEnvRes
{
    static class Util
    {
        public static void RandomZoombini(Dictionary<int, string> nameDict)
        {
            var random = new Random();

            var noseColor = ((NoseColor)random.Next(1, Enum.GetNames(typeof(NoseColor)).Length));
            var eyes = ((EyeType)random.Next(1, Enum.GetNames(typeof(EyeType)).Length));
            var hair = ((Hairstyle)random.Next(1, Enum.GetNames(typeof(Hairstyle)).Length));
            var feet = ((FootType)random.Next(1, Enum.GetNames(typeof(FootType)).Length));

            var name = nameDict[random.Next(1, nameDict.Count + 1)];
            
            new Zoombini(noseColor, eyes, hair, feet, name);
        }

        public static bool MouseIsInBounds(MouseState state, IClickable item)
        {
            if (
                state.X >= item.Position.X - (item.Texture.Width / 2) &&
                state.X <= item.Position.X + (item.Texture.Width / 2) &&
                state.Y >= item.Position.Y - (item.Texture.Height / 2) &&
                state.Y <= item.Position.Y + (item.Texture.Height / 2))
            {
                return true;
            }
            return false;
        }
    }
}