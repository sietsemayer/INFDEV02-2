using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum {
    //- A factory "F", which builds instances of interface "I", which can be implemented by classes "A", "B", and "C". 
    //"I" has a method "describe" which returns a string describing the current instance;
    class F {
        public I createObject(options o) {
            switch( o ) {
                case options.ObjectA:
                    return new A();
                case options.ObjectB:
                    return new B();
                case options.ObjectC:
                    return new C();
            }
            return null;
        }
        public enum options { ObjectA, ObjectB, ObjectC };
    }
    public interface I {
        string describe();
    }

    public class A : I {
        public string describe() {
            return "I'm Number A";
        }
    }
    public class B : I {
        public string describe() {
            return "I'm Number B";
        }
    }
    public class C : I {
        public string describe() {
            return "I'm Number C";
        }
    }
}
