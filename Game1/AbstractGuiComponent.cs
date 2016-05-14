using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1 {
    abstract class AbstractGuiComponent
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }


        //abstract public void paint();
        abstract public void paint( Game1 parent );
    }
}
