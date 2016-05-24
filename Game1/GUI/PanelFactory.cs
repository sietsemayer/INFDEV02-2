using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GUI {
    class PanelFactory {

        public static AbstractGuiComponent generatePanel( ContentManager Content ) {
            GUIContainer cont = new GUIContainer();
            cont.components.Add(new Button(10, 100, 100, 25, "click me", Content.Load<SpriteFont>("Pesca")));
            cont.components.Add(new Label("test", Content.Load<SpriteFont>("Pesca"), 10, 160));
            return cont;
        }
    }
}
