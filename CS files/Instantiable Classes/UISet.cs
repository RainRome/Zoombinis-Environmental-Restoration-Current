using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace ZoombinisEnvRes
{
    class VerticalButtonSet //sets the Position of a set of buttons
    {
        public List<UIItem> Buttons
        { set; get; }
        public Vector2 Position
        { set; get; }
        public int Buffer
        { set; get; }
        public float height;

        public VerticalButtonSet(Vector2 pos, int buffer, List<UIItem> buttons)
        {
            this.Buttons = buttons;
            this.Position = pos;
            this.Buffer = buffer;
            float startingYPos = this.Position.Y;
            float currentYPos = this.Position.Y;
            for (int i = 0; i < Buttons.Count; i++)
            {
                Vector2 item;
                item.X = this.Position.X;
                item.Y = currentYPos + Buffer;
                Buttons[i].Position = item;

                currentYPos += Buttons[i].Texture.Height * Buttons[i].Scale + Buffer;
            }
            height = currentYPos - startingYPos;
        }

        public void Move(Vector2 pos)
        {
            this.Position = pos;
            float startingYPos = this.Position.Y;
            float currentYPos = this.Position.Y;
            for (int i = 0; i < Buttons.Count; i++)
            {
                Vector2 item;
                item.X = this.Position.X;
                item.Y = currentYPos + Buffer;
                Buttons[i].Position = item;

                currentYPos += Buttons[i].Texture.Height * Buttons[i].Scale + Buffer;
            }
            height = currentYPos - startingYPos;
        }
    }
}