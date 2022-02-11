using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZoombinisEnvRes
{
    interface IClickable
    {
        Texture2D Texture
        { set; get; }
        Vector2 Position
        { set; get; }
    }
}