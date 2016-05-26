using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1;

namespace GUI {
    class GUIContainer : AbstractGuiComponent {
        public List<AbstractGuiComponent> components { get; } = new List<AbstractGuiComponent>();

        public override void paint( iGame parent ) {
            foreach( var item in components ) {
                item.paint(parent);
            }
        }

        public override void update( iGame parent ) {
            foreach( var item in components ) {
                item.update(parent);
            }
        }
    }
}
