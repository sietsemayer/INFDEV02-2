using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Button : AbstractGuiComponent
    {
        public Button(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void paint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), x, y, width, height);
        }

    }
}
