﻿using System;
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
            form.Container.Add(wfa);
            wfa.add(new Button());

            DialogResult result = form.ShowDialog();

        }
    }
}
