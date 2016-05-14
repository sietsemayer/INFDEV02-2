using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class WindowsFormsAdaptor : Control, IEnumerable
    {
        private List<AbstractGuiComponent> components = new List<AbstractGuiComponent>();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void add(AbstractGuiComponent comp)
        {
            components.Add(comp);
        }
        public void paint(PaintEventArgs e)
        {
            foreach (AbstractGuiComponent guiObject in components)
            {
                guiObject.paint(e);
            }
        }
    }
}
