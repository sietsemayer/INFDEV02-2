using System;

namespace Game1 {
    interface IGUIButton
    {
        void addListener(Action listener);
        void removeListener(Action listener);
    }
}
