using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;

namespace Game1 {
    class Button : AbstractGuiComponent { 


        Vector2 location;
        Texture2D tex;
        Color[] data;
        public Button(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
             location = new Vector2(x, y);

            data = new Color[width * height];
            for( int pixel = 0 ; pixel < data.Count() ; pixel++ ) {
                //the function applies the color according to the specified pixel
                data[pixel] = Color.White;
            }

        }
        public override void paint( Game1 parent )
        {
            if( tex == null ) {
                tex = new Texture2D(parent.GraphicsDevice, width, height);
                tex.SetData(data);
            }
            
            parent.spriteBatch.Draw(tex, location, Color.White);

        }

    }
}
