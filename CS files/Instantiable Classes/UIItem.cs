using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace ZoombinisEnvRes
{
    class UIItem : IClickable
    {
        //Button
        public Texture2D Texture
        { set; get; }
        public Vector2 Position
        { set; get; }
        public float Scale
        { set; get; }
        public string PathToTexture
        { set; get; }

        //Text
        public string Text
        { set; get; }
        public SpriteFont Font
        { set; get; }
        public float TextScale
        { set; get; }
        public Color TextColor
        { set; get; }

        //Check
        public bool HasBeenClicked
        { set; get; }

        //Constructors
        public UIItem(float scale)
        {
            this.Scale = scale;
        }
        public UIItem(float scale, float textScale)
        {
            this.Scale = scale;
            this.TextScale = textScale;
        }

        //Check if clicked and Draw & Load Methods
        public bool CheckIfClicked(MouseState mouseState, MouseState oldMouseState)
        {
            if (oldMouseState.LeftButton == ButtonState.Pressed && mouseState.LeftButton == ButtonState.Released && Util.MouseIsInBounds(mouseState, this))
            {
                HasBeenClicked = true;
            }
            if (HasBeenClicked == false)
            {
                HasBeenClicked = false;
            }
            return HasBeenClicked;
        }

        public void Load(ContentManager content, string filename)
        {
            this.Texture = content.Load<Texture2D>(filename);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(samplerState: SamplerState.AnisotropicWrap);
            spriteBatch.Draw
            (
                this.Texture,
                this.Position,
                null,
                Color.White,
                0f,
                new Vector2(this.Texture.Width / 2, this.Texture.Height / 2),
                Scale,
                SpriteEffects.None,
                0f
            );
            if (!string.IsNullOrEmpty(Text))
            {
                spriteBatch.DrawString
                (
                    Font,
                    Text,
                    Position,
                    TextColor,
                    0f,
                    Font.MeasureString(Text) / 2,
                    TextScale,
                    SpriteEffects.None,
                    0f
                );
            }
            spriteBatch.End();
        }
    }
}