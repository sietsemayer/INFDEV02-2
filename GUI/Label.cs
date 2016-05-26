using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    class Label : AbstractGuiComponent {

        private SpriteFont font;
        public string text { get; set; }

        public Label(string text, SpriteFont font, int x, int y) {
            this.text = text;
            this.font = font;
            this.x = x;
            this.y = y;

        }

        public override void paint( Game1 parent ) {
            parent.spriteBatch.DrawString(font, text, new Vector2(x, y), Color.Black);
        }
    }
}
