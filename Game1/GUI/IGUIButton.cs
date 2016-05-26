using System;

namespace GUI {
    interface IGUIButton
    {
        void addListener(Action listener);
        void removeListener(Action listener);
        void executeListeners();
    }
}
