using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    interface IGUIButton
    {
        void addListener(Action listener);
        void removeListener(Action listener);
    }
}
