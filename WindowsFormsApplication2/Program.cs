using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();

            WindowsFormsAdaptor wfa = new WindowsFormsAdaptor();
            form.Controls.Add(wfa);
            wfa.add(new Button(1,1,10,10));
           // wfa.paint();

            DialogResult result = form.ShowDialog();

        }
    }
}
