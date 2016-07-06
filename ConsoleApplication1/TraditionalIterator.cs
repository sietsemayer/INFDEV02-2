using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum {
    public interface TraditionalIterator<T> {
        bool hasNext();
        T next();
        T current { get; }
    }

    public class TestArrayTrad : TraditionalIterator<int> {

        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int current = 0;

        int TraditionalIterator<int>.current {
            get {
                return testArray[current];
            }
        }

        public bool hasNext() {
            return ( current + 1 <= testArray.Length );
        }

        public int next() {
            if( current <= testArray.Length ) {
                var returnint = testArray[current];
                current++;
                return returnint;
            } 
            throw new IndexOutOfRangeException();
            
        }
    }
}
