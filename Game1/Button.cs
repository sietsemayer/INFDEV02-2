using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;

namespace Game1 {
    class Button : AbstractGuiComponent
    {
        public Button(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void paint( Game1 parent )
        {
            Vector2 location = new Vector2(x, y);
            Texture2D tex = new Texture2D(parent.GraphicsDevice, width, height);
            Color[] data = new Color[width * height];
            for( int pixel = 0 ; pixel < data.Count() ; pixel++ ) {
                //the function applies the color according to the specified pixel
                data[pixel] = Color.White;
            }
            tex.SetData(data);

            parent.spriteBatch.Draw(tex, location, Color.White);

        }

    }
}
