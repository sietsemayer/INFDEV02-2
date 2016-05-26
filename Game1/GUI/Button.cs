using Game1;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;
using System.Linq;
using System;
using Microsoft.Xna.Framework.Input;

namespace GUI {
    class Button : AbstractGuiComponent, IGUIButton { 


        Vector2 location;
        Texture2D tex;
        Color[] data;
        Rectangle clickableArea;
        AbstractGuiComponent text;
        Action listeners;
        public Button(int x, int y, int width, int height, string text, SpriteFont font)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
             location = new Vector2(x, y);
            this.text = new Label(text, font, x +1, y+1);
            data = new Color[width * height];
            for( int pixel = 0 ; pixel < data.Count() ; pixel++ ) {
                //the function applies the color according to the specified pixel
                data[pixel] = Color.White;
            }
            this.clickableArea = new Rectangle(x, y, width, height);

        }
        public override void paint( iGame parent )
        {
            if( tex == null ) {
                tex = new Texture2D(parent.GraphicsDevice, width, height);
                tex.SetData(data);
            }
            
            parent.spriteBatch.Draw(tex, location, Color.Gold);
            this.text.paint(parent);

        }

        public override void update( iGame parent ) { 
            if( clickableArea.Contains(parent.getMouseState().X, parent.getMouseState().Y) ) {
                //Debug.WriteLine("mouse over button;");
                if( parent.getMouseState().LeftButton == ButtonState.Pressed ) {
                    //Debug.WriteLine("Mouse Clicked;");
                    this.executeListeners();
                }
            } else {
                //Debug.WriteLine(parent.getMousePoint().ToString());
            }
        }

        public void addListener( Action listener ) {
            this.listeners += listener;
        }

        public void removeListener( Action listener ) {
            this.listeners -= listener;
        }

        public void executeListeners() {
            if ( this.listeners != null ) {
                listeners();
            }

        }
    }
}
